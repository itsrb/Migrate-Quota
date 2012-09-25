using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace Migrate_Quota
{
    class Quota
    {
        

    ///path:<Path>

    ///sourcetemplate:<TemplateName>

    ///limit:<Limit>[kb | mb | gb]

    ///type:{hard | soft}

    ///status:{enabled | disabled}

    ///add-threshold:<Level> [...]

    ///add-notification:<Level>,<NotifyType>,<ConfigFile> [...]

    ///overwrite | /ignore

    ///remote:<ComputerName>


        public String path, newPath;
        public String template;
        public String limit;
        public enum typ { hard, soft }
        public Boolean status = false;
        public ArrayList threshold;
        public String pushResult = "";
        public Boolean pushed = false;
        public Boolean enabled = true;

        public Quota(String path, String template, String limit, String status, ArrayList threshold)
        {
            this.path = path;
            this.template = template;
            this.limit = limit;
            this.threshold = new ArrayList(threshold);
        }

        

        public Quota() : this("", "", "", "", new ArrayList()) { }
        
        private void setThreshold(ArrayList threshold)
        {
            throw new NotImplementedException();
        }

        private void setLimit(string limit)
        {
            
            throw new NotImplementedException();
        }

        public void setNewPath(System.Windows.Forms.DataGridViewRowCollection rows)
        {

            this.newPath = this.path.ToLower();
            for (int i = 0; i < rows.Count; i++)
            {
              
                if (rows[i].Cells[0].Value != null && rows[i].Cells[1].Value != null)
                    this.newPath=this.newPath.Replace(rows[i].Cells[0].Value.ToString().ToLower(), rows[i].Cells[1].Value.ToString().ToLower());
            }
        }

        public String ToString()
        {
            String output="";
            output += GUI_migrateQuota.parameter.path.ToString()+": "+this.newPath+"\n\r";
            output += "Pushed: "+this.pushed+"\n\r";
            output += "Pushed Result: \n\r"+this.pushResult+"\n\r ########################################################### \n\r";
            return output;
        }
    }
}
