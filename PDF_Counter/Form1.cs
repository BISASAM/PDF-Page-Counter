using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_Counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();       
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            lbl_version.Text = "v0.21";
            uiBeforeJob();
            
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_folderpath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_cwd_Click(object sender, EventArgs e)
        {
            tb_folderpath.Text = Directory.GetCurrentDirectory();
        }

        private void btn_show_files_Click(object sender, EventArgs e)
        {
            // Set to "details view".
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            //clear ListView
            listView1.Items.Clear();

            lbl_status.Text = "Bereit";
            lbl_total_count.Text = "0";
            lbl_filecount.Text = "0";

            string path_A = tb_folderpath.Text.TrimEnd('\\', '/', ' ');

            // create array of all files
            try
            {
                var recursive = cb_subfolder.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
                var filepaths = Directory.GetFiles(path_A, "*.pdf", recursive);
                lbl_filecount.Text = filepaths.Length.ToString() + " Dateien";

                // populate listview
                foreach (var entry in filepaths)
                {
                    listView1.Items.Add(new ListViewItem(new[] {"", Path.GetFileName(entry), "?", Path.GetDirectoryName(entry) }));
                }
              
                btn_count.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_count_Click(object sender, EventArgs e)
        {           
            if (backgroundWorker1.IsBusy != true)
            {
                var paths = new List<(int, string)>();
                for (var i = 0; i < listView1.Items.Count; i++)
                {   
                    var item = listView1.Items[i];
                    paths.Add((i, item.SubItems[3].Text + "\\" + item.SubItems[1].Text));
                }

                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync(paths);
                uiWhileJob();
            }

        }

        private void btn_abort_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                backgroundWorker1.CancelAsync();
            }
        }


        // This event handler is where the time-consuming work is done.
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            int total_files = listView1.Items.Count;

            int counter = 0;
            int total_pages = 0;
            try
            {
                foreach (var item in (List<(int Index, string Name)>)e.Argument)
                {
                    if (worker.CancellationPending == true)
                    {
                        e.Cancel = true;
                        break;
                    }
                    else
                    {
                        
                        counter++;
                        int page_count = getNumberOfPdfPages(item.Name);

                        total_pages = total_pages + page_count;
                        int p = (int)((float)counter / (float)total_files * 100);
                        
                        worker.ReportProgress(p, (item.Index, page_count, total_pages));
                        Debug.WriteLine(counter);                   
                    }
                }

                e.Result = total_pages;              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // This event handler updates the progress.
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lbl_status.Text = e.ProgressPercentage.ToString() + "%";
            (int idx, int page_count, int total_pages) temp = ((int, int, int)) e.UserState;
            listView1.Items[temp.idx].SubItems[2].Text = temp.page_count.ToString();
            listView1.Items[temp.idx].SubItems[0].Text = "\u25B6";
            listView1.EnsureVisible(temp.idx);
            lbl_total_count.Text = temp.total_pages.ToString();
        }

        // This event handler deals with the results of the background operation.
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                //lbl_status.Text = "Canceled!";
                uiBeforeJob();
            }
            else if (e.Error != null)
            {
                //lbl_status.Text = "Error: " + e.Error.Message;
                uiBeforeJob();
            }
            else
            {
                lbl_total_count.Text = e.Result.ToString();
                uiBeforeJob();
            }
        } 
    
        private static int getNumberOfPdfPages(string pathDocument)
        {
            return new iTextSharp.text.pdf.PdfReader(pathDocument).NumberOfPages;
        }

        private void uiBeforeJob()
        {
            btn_show_files.Enabled = true;
            btn_count.Enabled = false;
            btn_abort.Enabled = false;
            btn_browse.Enabled = true;
            btn_cwd.Enabled = true;
            cb_subfolder.Enabled = true;
        }

        private void uiWhileJob()
        {
            btn_show_files.Enabled = false;
            btn_count.Enabled = false;
            btn_abort.Enabled = true;
            btn_browse.Enabled = false;
            btn_cwd.Enabled = false;
            cb_subfolder.Enabled = false;
        }

    }
}
