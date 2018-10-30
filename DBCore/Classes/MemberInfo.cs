using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBCore.Common;
using MySql.Data.MySqlClient;

namespace DBCore.Classes
{
    public class MemberInfo : DBBase, IDBFunctions
    {
        public int ID;
        public string Name;
        public string Address;
        public DateTime DOB;
        public string NIC;
        public string Mobile;
        public string HomeTP;
        public string Email;
        public int Occupatition;
        public string OccupatitioInfo;
        public DateTime DOJoinAsapuwa;
        public string Abilities;
        public string Contributition;
        public string BloodGroup;
        public int Sex; // 1 = male 2 = female
        public int CivilStatus; // married = 1 unmarried = 2
        public string ImageData;
        public string IndexNumber;
        public int School;
        public int EduQualifications;
        public string OtherQualifications;
        public int DataVerified;
        public List<Tag> Tags;
        public MemberType MemberType;


        #region IDBFunctions Members

        public MemberInfo()
        {

        }

        public MemberInfo(bool withConn, MemberType memberType)
            : base(withConn)
        {
            MemberType = memberType;
        }

        public int Add()
        {
            AddParameter("@p_Name", Name);
            AddParameter("@p_Address", Address);
            AddParameter("@p_DOB", DOB);
            AddParameter("@p_NIC", NIC);
            AddParameter("@p_Mobile", Mobile);
            AddParameter("@p_HomeTP", HomeTP);
            AddParameter("@p_Email", Email);
            AddParameter("@p_Occupatition", Occupatition);
            AddParameter("@p_OccupatitioInfo", OccupatitioInfo);
            AddParameter("@p_DOJoinAsapuwa", DOJoinAsapuwa);
            AddParameter("@p_Abilities", Abilities);
            AddParameter("@p_Contributition", Contributition);
            AddParameter("@p_BloodGroup", BloodGroup);
            AddParameter("@p_Sex", Sex);
            AddParameter("@p_CivilStatus", CivilStatus);
            AddParameter("@p_ImageData", ImageData);
            AddParameter("@p_IndexNumber", IndexNumber);
            AddParameter("@p_School", School);
            AddParameter("@p_EduQualifications", EduQualifications);
            AddParameter("@p_OtherQualifications", OtherQualifications);
            AddParameter("@p_DataVerified", DataVerified);
            AddParameter("@p_MemberType", (int)MemberType);
            AddParameter("@p_ID", MySqlDbType.Int32);


            int ret = ExecuteNonQueryOutput("Member_Add");

            ID = (int)GetOutputValue("@p_ID");


            if (Tags != null)
            {
                foreach (Tag tg in Tags)
                {
                    AddTag(tg.ID);

                }
            }

            return ret;
        }

        public System.Data.DataTable SelectAll()
        {
            return GetTable("Member_SelAll");
        }

        public int Delete()
        {
            AddParameter("@p_ID", ID);

            return ExecuteNonQuery("Member_Del");
        }

        public int Update()
        {


            AddParameter("@p_Name", Name);
            AddParameter("@p_Address", Address);
            AddParameter("@p_DOB", DOB);
            AddParameter("@p_NIC", NIC);
            AddParameter("@p_Mobile", Mobile);
            AddParameter("@p_HomeTP", HomeTP);
            AddParameter("@p_Email", Email);
            AddParameter("@p_Occupatition", Occupatition);
            AddParameter("@p_OccupatitioInfo", OccupatitioInfo);
            AddParameter("@p_DOJoinAsapuwa", DOJoinAsapuwa);
            AddParameter("@p_Abilities", Abilities);
            AddParameter("@p_Contributition", Contributition);
            AddParameter("@p_BloodGroup", BloodGroup);
            AddParameter("@p_Sex", Sex);
            AddParameter("@p_CivilStatus", CivilStatus);
            AddParameter("@p_ImageData", ImageData);
            AddParameter("@p_School", School);
            AddParameter("@p_EduQualifications", EduQualifications);
            AddParameter("@p_OtherQualifications", OtherQualifications);
            AddParameter("@p_DataVerified", DataVerified);

            AddParameter("@p_ID", ID);

            return ExecuteNonQuery("Member_Upd");
        }

        #endregion


        public System.Data.DataTable SelectFind()
        {

            AddParameter("@p_Name", Name);
            AddParameter("@p_NIC", NIC);
            AddParameter("@p_Mobile", Mobile);
            AddParameter("@p_HomeTP", HomeTP);
            AddParameter("@p_Email", Email);
            AddParameter("@p_BloodGroup", BloodGroup);
            AddParameter("@p_Occupatition", Occupatition);
            AddParameter("@p_Sex", Sex);
            AddParameter("@p_CivilStatus", CivilStatus);
            AddParameter("@p_IndexNumber", IndexNumber);
            AddParameter("@p_School", School);
            AddParameter("@p_EduQualifications", EduQualifications);
            AddParameter("@p_DataVerified", DataVerified);
            AddParameter("@p_Abilities", Abilities);
            AddParameter("@p_Contributition", Contributition);
            AddParameter("@p_OtherQualifications", OtherQualifications);
            AddParameter("@p_OccupatitionInfo", OccupatitioInfo);
            AddParameter("@p_MemberType", (int)MemberType);

            if (Tags.Count > 0)
            {
                AddParameter("@p_Tag", Tags[0].ID);
            }
            else
            {
                AddParameter("@p_Tag", -1);
            }

            return GetTable("Member_Find");

        }


        public MemberInfo SelectMember(int ID)
        {

            AddParameter("@p_ID", ID);

            using (MySqlDataReader reader = ExecuteReader("Member_Sel"))
            {


                if (reader.Read())
                {
                    Name = reader.GetString(0);
                    Address = reader.GetString(1);
                    DOB = reader.GetDateTime(2);
                    NIC = reader.GetString(3);
                    Mobile = reader.GetString(4);
                    HomeTP = reader.GetString(5);
                    Email = reader.GetString(6);
                    Occupatition = reader.GetInt32(7);
                    OccupatitioInfo = reader.GetString(8);
                    DOJoinAsapuwa = reader.GetDateTime(9);
                    Abilities = reader.GetString(10);
                    Contributition = reader.GetString(11);
                    BloodGroup = reader.GetString(12);
                    Sex = reader.GetInt32(13);
                    CivilStatus = reader.GetInt32(14);
                    ImageData = reader.GetString(15);
                    IndexNumber = reader.GetString(16);
                    School = reader.GetInt32(17);
                    EduQualifications = reader.GetInt32(18);
                    OtherQualifications = reader.GetString(19);
                    DataVerified = reader.GetInt32(20);
                } 
            }

            Tags = GetTags(ID);

            return this;
        }
        
        
        public MemberInfo SelectMemberFromIndex(string index)
        {

            AddParameter("@p_index", index);

            using (MySqlDataReader reader = ExecuteReader("Member_SelIndex"))
            {


                if (reader.Read())
                {
                    Name = reader.GetString(0);
                    Address = reader.GetString(1);
                    DOB = reader.GetDateTime(2);
                    NIC = reader.GetString(3);
                    Mobile = reader.GetString(4);
                    HomeTP = reader.GetString(5);
                    Email = reader.GetString(6);
                    Occupatition = reader.GetInt32(7);
                    OccupatitioInfo = reader.GetString(8);
                    DOJoinAsapuwa = reader.GetDateTime(9);
                    Abilities = reader.GetString(10);
                    Contributition = reader.GetString(11);
                    BloodGroup = reader.GetString(12);
                    Sex = reader.GetInt32(13);
                    CivilStatus = reader.GetInt32(14);
                    ImageData = reader.GetString(15);
                    IndexNumber = reader.GetString(16);
                    School = reader.GetInt32(17);
                    EduQualifications = reader.GetInt32(18);
                    OtherQualifications = reader.GetString(19);
                    DataVerified = reader.GetInt32(20);
                    ID = reader.GetInt32(21);
                } 
            }

            Tags = GetTags(ID);

            return this;
        }

        public int ValidateIndexNICNumbers(string nic, string index, int id)
        {

            AddParameter("@p_NIC", nic);
            AddParameter("@p_IndexNumber", index);
            AddParameter("@p_MemberType", (int)MemberType);

            bool dupNIC = false, dupIndex = false;

            using (MySqlDataReader reader = ExecuteReader("Validate_IndexNICNumber"))
            {
                while (reader.Read())
                {
                    if (id == reader.GetInt32(2))
                        continue;

                    if (!dupNIC && nic == reader.GetString(0))
                    {
                        dupNIC = true;
                    }

                    if (!dupIndex && index == reader.GetString(1))
                    {
                        dupIndex = true;
                    }
                }
            }

            if (dupIndex & dupNIC)
                return 4;

            if (dupIndex)
                return 3;

            if (dupNIC)
                return 2;

            return 1;
        }

        public string GetNextIndex()
        {
            try
            {
                ClearParameters();

                AddParameter("@p_MemberType", (int)MemberType);

                string curruntMaxIndex = ExecuteScalar("Member_MaxIndex").ToString();

                int indexNumber = Int32.Parse(curruntMaxIndex.Substring(4));

                return curruntMaxIndex.Replace(indexNumber.ToString(), (indexNumber + 1).ToString());

            }
            catch
            {
                return "YBS_";
            }
        }


        public int AddTag(int tagID)
        {
            AddParameter("@p_MemberID", ID);
            AddParameter("@p_TagID", tagID);

            return ExecuteNonQuery("MemberTag_Add");
        }

        public int RemoveMemberTag(int id)
        {
            AddParameter("@p_ID", id);

            return ExecuteNonQuery("MemberTag_Del");
        }

        public List<Tag> GetTags(int id)
        {
            List<Tag> tag = new List<Tag>();

            //string SQL = "SELECT b.ID,b.AsapuID,b.FromDate,b.ToDate,a.AsapuwaName FROM BhikkuAsapu b LEFT JOIN Asapuwa a ON  b.AsapuID = a.ID WHERE b.BhikkuID = @BhikkuID AND b.Deleted = 0";

            AddParameter("@p_memberID", id);

            using (MySqlDataReader reader = ExecuteReader("MemberTag_sel"))
            {
                while (reader.Read())
                {
                    tag.Add(new Tag(reader.GetInt32(0), reader.GetString(1),"",reader.GetInt32(2)));
                }
            }

            return tag;
        }
    }
}
