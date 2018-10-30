﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBCore.Common;
using System.Windows.Forms;
using System.Data;

namespace DBCore.Classes
{
    public class School : DBBase, IDBFunctions
    {
         public int ID;
        public string Name;

           public School()
        {

        }

           public School(bool withConn)
            : base(withConn)
        {

        }

        #region IDBFunctions Members

        public int Add()
        {
            AddParameter("@p_Name", Name);

            return ExecuteNonQueryOutput("Sch_Add");
        }

        public System.Data.DataTable SelectAll()
        {
            return GetTable("Sch_SelAll");
        }

        public int Delete()
        {
            AddParameter("@p_ID", ID);

            return ExecuteNonQuery("Sch_Del");
        }

        public int Update()
        {
            AddParameter("@p_Name", Name);
            AddParameter("@p_ID", ID);

            return ExecuteNonQuery("Sch_Upd");
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

             return GetTable("Sch_Find");
         }
    }
}
