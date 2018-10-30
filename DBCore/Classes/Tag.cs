using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBCore.Common;
using System.Windows.Forms;
using System.Data;

namespace DBCore.Classes
{
    public class Tag : DBBase, IDBFunctions
    {
        public int MemberTagID;
        public int ID;
        public string Name;
        public string Description;


        public Tag(int id,string name,string des,int memTag)
        {
            ID = id;
            Name = name;
            Description = des;
            MemberTagID = memTag;
        }



        public Tag(bool withConn)
            : base(withConn)
        {

        }

        #region IDBFunctions Members

        public int Add()
        {
            AddParameter("@p_Name", Name);
            AddParameter("@p_Description", Description);

            return ExecuteNonQueryOutput("Tag_Add");
        }

        public System.Data.DataTable SelectAll()
        {
            return GetTable("Tag_SelAll");
        }

        public int Delete()
        {
            AddParameter("@p_ID", ID);

            return ExecuteNonQuery("Tag_Del");
        }

        public int Update()
        {
            AddParameter("@p_Name", Name);
            AddParameter("@p_Description", Description);
            AddParameter("@p_ID", ID);

            return ExecuteNonQuery("Tag_Upd");
        }

        #endregion

         public void BindToCombo(ComboBox combo)
        {
            DataTable tbl = SelectAll();

            combo.DataSource = tbl;

            combo.DisplayMember = "Name";
            combo.ValueMember = "ID";
        }

         public DataTable SelectFind()
         {
             AddParameter("@p_Name", Name);

             return GetTable("Tag_Find");
         }
    }
}
