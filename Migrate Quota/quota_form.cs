using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Xml;
namespace Migrate_Quota
{
    public partial class GUI_migrateQuota : Form
    {
        
        // Settings
        // WordMapping
        public enum parameter {path, template, limit, type, status, threshold, templatematch}
        ArrayList quotas = new ArrayList();
        Object lockvar = "";
        Thread sendThread;

        public String getParameter(String str, Boolean rev = true)
        {
            ArrayList param = new ArrayList();

            //String[,] de = new String[Enum.GetValues(typeof(parameter)).Length, 2];
            int i = 0;
            /*
            foreach (Enum enu in Enum.GetValues(typeof(parameter)))
            {
                if(wm_txtfields.Controls["wm_" + enu.ToString()]!=null)
                    de[i, 0] = wm_txtfields.Controls["wm_" + enu.ToString()].Text;
                de[i, 1] = enu.ToString();
                i++;
            }
            */
            String[,] de = new String[,] { { "Kontingentpfad", "path" }, { "Quellenvorlage", "template" }, { "Kontingentstatus", "status" }, { "Grenze", "limit"}, {"(Stimmt mit Vorlage überein)", "templatematch"} };

            int y = 0;
            int z = 1;
            if (rev) { z = 0; y = 1; }

            for( i = 0 ; i< de.Length/2; i++)
                if (de[i, y].Equals(str)) return de[i, z];
            
            return "";
        }

        public GUI_migrateQuota()
        {
            InitializeComponent();
            loadLanguage(this.Controls,"en");
            showWordmapping();
            this.Text += " (" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + ")";
            
        }



        private void loadLanguage(Control.ControlCollection controlCollection,String lang)
        {
            XmlTextReader reader = new XmlTextReader(Directory.GetCurrentDirectory()+"\\lang\\"+lang+".xml");
            
            XmlDocument doc = new XmlDocument();
            reader.Read();
            doc.Load(reader);
            ArrayList controls = new ArrayList();
            foreach (Control ctrl in controlCollection)
            {
                if (doc.GetElementsByTagName(ctrl.Name)[0] != null)
                    ctrl.Text = doc.GetElementsByTagName(ctrl.Name)[0].InnerText;
                controls.Add(ctrl.Name);

                if (ctrl.Controls.Count>0) 
                    loadLanguage(ctrl.Controls, lang);
            }

        }


        private void btn_searchQuotaList_Click(object sender, EventArgs e)
        {
            OpenFileDialog quotaListPath = new OpenFileDialog();
            //quotaListPath.Filter = "txt Files (*.txt)|*.txt";

            if (quotaListPath.ShowDialog() == DialogResult.OK)
            {
                txt_quotaListPath.Text = quotaListPath.FileName;
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {

            if (txt_quotaListPath.Text != "")
            {
                Cleanup();
                //FileStream fileStream = new FileStream(@+txt_quotaListPath.Text, FileMode.Open);

                //** Datei muss über CMD mit "mode con cp select=1252" exportiert werden **/
                try
                {
                    Encoding ANSI = Encoding.GetEncoding(1252);
                    TextReader read = new StreamReader(txt_quotaListPath.Text, ANSI);
                    ArrayList file = new ArrayList();

                    try
                    {


                        String line;
                        while ((line = read.ReadLine()) != null)
                        {
                            file.Add(line.Replace("   ", ""));
                        }
                    }
                    finally
                    {
                        read.Close();
                    }

                    txt_listFile.Text = "";
                    String txt = "";

                    foreach (String line in file)
                        txt += line.ToString() + "\r\n";

                    txt_listFile.Text = txt;

                    readData(file);
                }
                catch (Exception)
                {
                    MessageBox.Show("Die Datei konnte nicht gefunden oder nicht geöffnet werden", "Fehler beim Öffnen der Datei", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ClearStatus();
            LoadLístbox();

        }

        private void Cleanup()
        {
            txt_listFile.Text = "";
            quotas = new ArrayList();
            ClearStatus();
            listView1.Clear();
            
        }

        private void ClearStatus()
        {
            
            show_anzQuota.Text = quotas != null ? quotas.Count.ToString() : "";
            show_progress.Maximum = quotas != null ? quotas.Count : 100;
            show_progress.Value = 0;
            show_error.Text = "0";
            show_success.Text = "0";
            show_currentPath.Text = "";
            show_currentTemplate.Text = "";
        }

        private void LoadLístbox()
        {
            listView1.Clear();
            if(listView1.Columns[getParameter(parameter.path.ToString())]==null)
                listView1.Columns.Add(getParameter(parameter.path.ToString()));
            if (listView1.Columns[getParameter(parameter.path.ToString())+" (new)"] == null)
                listView1.Columns.Add(getParameter(parameter.path.ToString())+" (new)");
            if(quotas != null)
            foreach (Quota q in quotas)
            {
                q.setNewPath(dataGridView1.Rows);
                ListViewGroup grp = new ListViewGroup(q.template, q.template);
                
                if (listView1.Groups[q.template]==null)
                {
                    listView1.Groups.Add(grp);
                }
                //listView1.Groups[q.template].Items.Add(q.path).SubItems.Add(q.template);
                ListViewItem tmp = new ListViewItem();
                tmp.Name = q.path.Trim();
                tmp.Text = q.path;
                tmp.Checked = true;
                tmp.Tag = q;
                listView1.Items.Add(tmp).SubItems.Add(q.newPath);
                listView1.Items[q.path.Trim()].Group = listView1.Groups[q.template];
            }

            listView1.Columns[0].Width = listView1.Width / 2 - 25;
            listView1.Columns[1].Width = listView1.Width / 2 - 25;
            listView1.Refresh();


            
        }

        private void readData(ArrayList file)
        {
            ArrayList row = new ArrayList();
            ArrayList head = new ArrayList();
            //ArrayList quotas = new ArrayList();
            
            
            
            foreach (String line in file)
            {
                String[] data = new String[2];

                //dg_quotaData.Columns.Add("limit", "limit");
                //dg_quotaData.Columns.Add("path", "limit");
                //dg_quotaData.Columns.Add("template", "limit");

                if (line != "")
                {
                    data[0] = line.Substring(0, line.IndexOf(':'));
                    if ((line.IndexOf(':') - line.Length) < -1)
                        data[1] = line.Substring(line.IndexOf(':') + 1, line.Length - line.IndexOf(':') - 1);

                    if (data[1] != null && data[1] != "")
                    {

                        if (head.Contains(data[0]))
                        {
                            pushData(head, row);
                            //dg_quotaData.Rows.Add("1", "3");
                            row.Clear();
                            head.Clear();
                        }

                        head.Add(data[0].TrimEnd().TrimStart());
                        row.Add(data[1].TrimEnd().TrimStart());
                    }
                }
            }
      }

        private void pushData(ArrayList head, ArrayList row)
        {

            Quota q = new Quota();
            
            q.limit     = row[head.IndexOf(getParameter(parameter.limit.ToString()))].ToString();
            q.path      = row[head.IndexOf(getParameter(parameter.path.ToString()))].ToString();
            q.template  = row[head.IndexOf(getParameter(parameter.template.ToString()))].ToString();
            
            
            quotas.Add(q);
            
            
        }

        private void send_command(Quota q)
        {
            string windir = Environment.GetEnvironmentVariable("WINDIR");
            
           // System.Diagnostics.Process.Start(@"\Sysnative\dirquota.exe");
            
            //System.Diagnostics.Process.Start(@"c:\windows\system32\dirquota.exe");
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = windir+"\\Sysnative\\dirquota.exe";
            p.StartInfo.Arguments = "quota add /path:\""+q.newPath+"\" /SourceTemplate:\""+q.template.Replace(getParameter(parameter.templatematch.ToString()),"").Trim()+"\" /Remote:"+server.Text+"";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            
            string sOutput;

            p.Start();
            StreamReader reader = p.StandardOutput;
            q.pushResult = reader.ReadToEnd();
            
            
            p.WaitForExit();
            q.pushed = p.ExitCode != 0 ? false : true;
            //MessageBox.Show(p.ExitCode.ToString());
            p.Close();
            //MessageBox.Show(sOutput);
            
            //dirquota quota add /path:"e:\Gruppen\PSK-Z Scherenarm 9mm" /SourceTemplate:"SIAU 02 GB-Grenze Gruppen" /Remote:FSHK1-32

            
        }


        private void insertQuotas_Click(object sender, EventArgs e)
        {
            
            btn_insertQuotas.Text= "Stop";

            if (sendThread == null || sendThread.IsAlive == false)
            {
                sendThread = new Thread(new ThreadStart(sendQuota));
                sendThread.IsBackground = true;         
                sendThread.Start();
                ClearStatus();
            }
            else
            {
                sendThread.Suspend();
                btn_insertQuotas.Text = "Senden";
                sendThread = null;
                ClearStatus();
                sendThread.Abort();
            }

        }


        private void sendQuota()
        {
            String tmp = "";
            foreach (Quota q in quotas)
            {
                
                //Pfadersetzungen
                q.setNewPath(dataGridView1.Rows);
                send_command(q);


                //Methode für Status Update in GUI
                MethodInvoker LabelUpdate = delegate{
                    show_currentPath.Text = q.newPath.ToString(); 
                    show_currentTemplate.Text = q.template;
                    int current;
                    if (q.pushed)
                    {
                        int.TryParse(show_success.Text, out current);
                        current++;
                        show_success.Text = current.ToString();
                    }
                    else
                    {
                        int.TryParse(show_error.Text, out current);
                        current++;
                        show_error.Text = current.ToString();
                    }
                    
                    
                };
                Invoke(LabelUpdate);
                MethodInvoker BarUpdate = delegate {show_progress.Value++;};
                Invoke(BarUpdate);
                //System.Threading.Thread.Sleep(250);
                
                tmp += q.ToString();
                
            }

            MethodInvoker endThread = delegate { btn_insertQuotas.Text = "Start";
            TabPage tb = new TabPage();
                tb.Text = "Log";
                tb.Name = "tb_log";
                TextBox txt = new TextBox();
                txt.Multiline = true;
                txt.Dock = txt_listFile.Dock;
                txt.Anchor = txt_listFile.Anchor;
                txt.Size = txt_listFile.Size;
                tb.Controls.Add(txt);
                txt.Lines = tmp.Split(new String[] {"\n\r"}, StringSplitOptions.None);
                
                txt.ReadOnly = true;
                txt.ScrollBars = ScrollBars.Both;
                tab.TabPages.Add(tb);
            };
            Invoke(endThread);
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

            
        }

        private void listView1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs args = (MouseEventArgs)e;
            if (args.Button == MouseButtons.Right)
            {
                Point pt = listView1.PointToScreen(args.Location);
                listOperations.Show(pt);
            }
        }

        private void enable_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                item.Checked = true;
            }
        }

        private void disable_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                item.Checked = false;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                quotas.Remove(item.Tag);
                item.Remove();
                
            }

            //updateQuotas();
            ClearStatus();
            
        }

        private void updateQuotas()
        {
            foreach (Quota q in quotas)
            {
                if (listView1.Items[q.path] == null)
                {
                    quotas.Remove(q);
                    break;
                    
                }
            }
            ClearStatus();
        }

        public void showWordmapping()
        {
            foreach(Enum enu in Enum.GetValues(typeof(parameter)))
            {
                TextBox tb = new TextBox();
                tb.Name = "wm_"+enu.ToString();
                tb.Text = getParameter(enu.ToString(),true);
                tb.Width = 200;

               

                Label lb = new Label();
                lb.Text = enu.ToString();
                lb.Name = "wm_value_"+enu.ToString();
                lb.Width = 100;
                lb.Padding = new Padding(0,6,0,0);

                wm_txtfields.Controls.Add(lb);
                wm_txtfields.Controls.Add(tb);
                
            }
        }

        private void wm_help_Click(object sender, EventArgs e)
        {

        }

        private void wm_help_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs args = (MouseEventArgs)e;
            if (args.Button == MouseButtons.Left)
            {
                Point pt = label10.PointToScreen(args.Location);
                language.Show(pt);
            }
        }

        private void lang_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ctrl = (ToolStripMenuItem)sender;
            loadLanguage(this.Controls, ctrl.Name);
            
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadLístbox();
        }

        private void txt_quotaListPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_pw_TextChanged(object sender, EventArgs e)
        {

        }
    
    
    }

 






}
