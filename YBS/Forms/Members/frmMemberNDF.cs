using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBCore.Classes;
using YBS.Common;
using System.Collections;
using System.IO;
using System.Drawing.Imaging;
using System.Net.Mail;
using DevComponents.Editors;


namespace YBS.Forms
{
    public partial class frmMemberNDF : DevComponents.DotNetBar.Office2007Form
    {
        int memberID = 0;
        byte[] imageData = null;
        string emailString = string.Empty;
        InputLanguage lan = InputLanguage.CurrentInputLanguage;
        string nextIndex = string.Empty;
        List<int> findIDList = new List<int>();
        int findListSelectedIndex = -1;
        DBCore.UserLevel userLevel = DBCore.UserLevel.SystemUser;
        DBCore.MemberType memberType;


        public frmMemberNDF(int permissionLevel, DBCore.MemberType member)
        {
            userLevel = (DBCore.UserLevel)permissionLevel;
            memberType = member;
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {

            try
            {

                using (MemberInfo memInfo = new MemberInfo(true, memberType))
                {
                    if (ValidateBeforeAdd(memInfo))
                    {

                        memInfo.NIC = nicText.Text;
                        memInfo.BloodGroup = bloodGroupCombo.Text;
                        memInfo.Name = nameTextBoxX.Text;
                        memInfo.Address = addressTextbox.Text;
                        memInfo.DOB = dobDate.Value.Date;
                        memInfo.Mobile = mobileText.Text;
                        memInfo.HomeTP = homeTpText.Text;
                        memInfo.Email = emailText.Text;
                        memInfo.Occupatition = occuCombo.SelectedValue == null ? -1 : (int)occuCombo.SelectedValue;
                        memInfo.OccupatitioInfo = occuText.Text;
                        memInfo.DOJoinAsapuwa = dojoindate.Value.Date;
                        memInfo.Abilities = abilityText.Text;
                        memInfo.Contributition = contribText.Text;
                        memInfo.IndexNumber = indexText.Text;
                        memInfo.School = schoolCombo.SelectedValue == null ? -1 : (int)schoolCombo.SelectedValue;
                        memInfo.EduQualifications = eduQuaCombo.SelectedValue == null ? -1 : (int)eduQuaCombo.SelectedValue;
                        memInfo.OtherQualifications = otheQualiText.Text;
                        memInfo.DataVerified = verifiedCheck.Checked ? 1 : 0;


                        if (bloodGroupCombo.SelectedItem != null)
                        {
                            ComboItem item = (ComboItem)bloodGroupCombo.SelectedItem;
                            memInfo.BloodGroup = item.Text;
                        }

                        memInfo.Sex = sexCombo.SelectedIndex;
                        memInfo.CivilStatus = civilStatusCombo.SelectedIndex;

                        if (imageData == null)
                        {
                            memInfo.ImageData = string.Empty;
                        }
                        else
                        {
                            memInfo.ImageData = Utility.Get64String(imageData);
                        }


                        if (memberID == 0)
                        {
                            addTagsToObject(memInfo);

                            if (memInfo.Add() == 1)
                            {
                                MessageView.ShowMsg("Sucessfully Added");

                                nextIndex = memInfo.GetNextIndex();

                                clear();
                            }

                        }
                        else
                        {
                            memInfo.ID = memberID;

                            if (MessageView.ShowQuestionMsg("Update Member info") == DialogResult.OK)
                            {

                                if (memInfo.Update() == 1)
                                {
                                    MessageView.ShowMsg("Sucessfully Updated");

                                    //errorProvider1.SetError(idTxt, string.Empty);
                                    //errorProvider1.SetError(nameTxt, string.Empty);

                                    clear();
                                }
                            }
                        }
                    }
                }

                // SetIndexField();
            }
            catch (Exception ex)
            {
                MessageView.ShowErrorMsg(ex.Message);
            }
        }

        private void addTagsToObject(MemberInfo memInfo)
        {
            memInfo.Tags = new List<Tag>();

            if (tagGrid.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in tagGrid.Rows)
                {
                    //DateTime fromDate = DateTime.Parse(row.Cells[3].Value.ToString());
                    //DateTime toDate = DateTime.Parse(row.Cells[4].Value.ToString());

                    memInfo.Tags.Add(new Tag((int)row.Cells[2].Value, "", "",0));
                }
            }
        }



        private void SetIndexField()
        {
            if (string.IsNullOrEmpty(nextIndex))
            {
                using (MemberInfo mem = new MemberInfo(true, memberType))
                {
                    nextIndex = mem.GetNextIndex();
                }
            }

            indexText.Text = nextIndex;
        }

        private void clear()
        {
            memberID = 0;
            addbtn.Text = "Insert";
            deleteBtn.Enabled = false;

            nicText.Clear();
            bloodGroupCombo.SelectedIndex = -1;
            nameTextBoxX.Clear();
            addressTextbox.Clear();
            dobDate.Value = DateTime.Now;

            homeTpText.Clear();
            emailText.Clear();
            occuCombo.SelectedIndex = -1;

            occuText.Clear();
            dojoindate.Value = DateTime.Now;
            abilityText.Clear();
            contribText.Clear();
            mobileText.Clear();
            sexCombo.SelectedIndex = -1;
            civilStatusCombo.SelectedIndex = -1;
            schoolCombo.SelectedIndex = -1;
            eduQuaCombo.SelectedIndex = -1;
            otheQualiText.Clear();
            pictureBox.Image = null;
            imageData = null;
            pictureBox.Size = new Size(250, 250);
            dobDate.Value = new DateTime();
            dojoindate.Value = new DateTime();
            emailString = string.Empty;
            indexText.ReadOnly = false;
            SetIndexField();
            nextBtn.Visible = false;
            prevBtn.Visible = false;
            findIDList.Clear();
            findListSelectedIndex = -1;

            verifiedCheck.CheckState = CheckState.Indeterminate;
            setUserPermissions();
            tagGrid.Rows.Clear();
        }

        private bool ValidateBeforeAdd(MemberInfo member)
        {
            bool retVal = true;

            int nicIndexValidator = member.ValidateIndexNICNumbers(nicText.Text, indexText.Text, memberID);


            if (string.IsNullOrEmpty(indexText.Text))
            {
                errorProvider1.SetError(indexText, "Index Number cannot be empty");
                retVal = false;
            }
            else
            {
                if ((nicIndexValidator == 4 || nicIndexValidator == 3))
                {
                    errorProvider1.SetError(indexText, "Duplicate Index number");
                    retVal = false;
                }
                else
                {
                    errorProvider1.SetError(indexText, string.Empty);
                }
            }



            if (string.IsNullOrEmpty(nameTextBoxX.Text))
            {
                errorProvider1.SetError(nameTextBoxX, "Name cannot be empty");
                retVal = false;
            }
            else
            {
                errorProvider1.SetError(nameTextBoxX, string.Empty);
            }


            if (!string.IsNullOrEmpty(nicText.Text) && nicText.Text.Length != 10)
            {
                errorProvider1.SetError(nicText, "Invalied 'NIC'");
                retVal = false;
            }
            else
            {
                double nicInt = 0;

                if (!string.IsNullOrEmpty(nicText.Text) && nicText.Text.Length == 10)
                {
                    if (double.TryParse(nicText.Text.Substring(0, 9), out nicInt) && !double.TryParse(nicText.Text.Substring(9, 1), out nicInt))
                    {

                        if (!string.IsNullOrEmpty(nicText.Text) && (nicIndexValidator == 4 || nicIndexValidator == 2))
                        {
                            errorProvider1.SetError(nicText, "Duplicate 'NIC'");
                            retVal = false;
                        }
                        else
                        {

                            errorProvider1.SetError(nicText, string.Empty);
                        }
                    }
                    else
                    {

                        errorProvider1.SetError(nicText, "Invalied 'NIC'");
                        retVal = false;
                    }
                }
                else
                {

                    errorProvider1.SetError(nicText, string.Empty);
                }
            }


            if (dobDate.Value != new DateTime() && dojoindate.Value != new DateTime() && dobDate.Value > dojoindate.Value)
            {
                errorProvider1.SetError(dojoindate, "Invalied 'Date Of Join', must greater than 'Date Of Birth'");
                retVal = false;
            }
            else
            {
                errorProvider1.SetError(dojoindate, string.Empty);
            }



            if (!string.IsNullOrEmpty(emailText.Text) && !Utility.IsValidEmailAddress(emailText.Text))
            {
                retVal = false;
                errorProvider1.SetError(emailText, "Invalied 'Email Address'");
            }
            else
            {
                errorProvider1.SetError(emailText, string.Empty);
            }

            if (Utility.IsValiedPhoneNumber(mobileText.Text))
            {
                errorProvider1.SetError(mobileText, string.Empty);

            }
            else
            {
                retVal = false;
                errorProvider1.SetError(mobileText, "Invalied Number");
            }


            if (Utility.IsValiedPhoneNumber(homeTpText.Text))
            {
                errorProvider1.SetError(homeTpText, string.Empty);
            }
            else
            {
                retVal = false;
                errorProvider1.SetError(homeTpText, "Invalied Number");
            }


            return retVal;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            using (MemberInfo member = new MemberInfo(true, memberType))
            {
                member.ID = memberID;

                if (MessageView.ShowQuestionMsg("Delete Details of '" + nameTextBoxX.Text + "'") == DialogResult.OK)
                {
                    member.Delete();
                    clear();
                    MessageView.ShowMsg("Sucessfully Deleted");
                }
            }

            SetIndexField();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshOccupationList();
            RefreshEduQualificationList();
            RefreshSchoolList();
            RefreshTagList();

            SetIndexField();
            indexText.SelectionStart = 15;


            setUserPermissions();
        }

        private void setUserPermissions()
        {
            if (userLevel == DBCore.UserLevel.SystemUser)
            {
                addbtn.Enabled = deleteBtn.Enabled = false;
            }

            if (userLevel == DBCore.UserLevel.SystemUser_I)
            {
                addbtn.Enabled = true;
                deleteBtn.Enabled = false;
            }

            if (userLevel == DBCore.UserLevel.SystemUser_IUD || userLevel == DBCore.UserLevel.SystemAdmin)
            {
                addbtn.Enabled = true;
            }
        }

        private void RefreshOccupationList()
        {
            using (Occupation occ = new Occupation(true))
            {
                occ.BindToCombo(occuCombo);

                occuCombo.SelectedIndex = -1;
            }
        }

        private void RefreshSchoolList()
        {
            using (School sch = new School(true))
            {
                sch.BindToCombo(schoolCombo);

                schoolCombo.SelectedIndex = -1;
            }
        }

        private void RefreshTagList()
        {
            using (Tag tg = new Tag(true))
            {
                tg.BindToCombo(tagCombobox);

                tagCombobox.SelectedIndex = -1;
            }
        }

        private void RefreshEduQualificationList()
        {
            using (EduQualifications edu = new EduQualifications(true))
            {
                edu.BindToCombo(eduQuaCombo);

                eduQuaCombo.SelectedIndex = -1;
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void findButton_Click(object sender, EventArgs e)
        {

            try
            {
                using (MemberInfo memInfo = new MemberInfo(true, memberType))
                {
                    memInfo.NIC = nicText.Text;

                    if (bloodGroupCombo.SelectedItem == null)
                    {
                        memInfo.BloodGroup = string.Empty;
                    }
                    else
                    {
                        memInfo.BloodGroup = ((ComboItem)bloodGroupCombo.SelectedItem).Text;
                    }

                    memInfo.Name = nameTextBoxX.Text;
                    memInfo.Mobile = mobileText.Text;
                    memInfo.HomeTP = homeTpText.Text;
                    memInfo.Email = emailText.Text;
                    memInfo.Occupatition = occuCombo.SelectedValue == null ? -1 : (int)occuCombo.SelectedValue;
                    memInfo.Sex = sexCombo.SelectedIndex;
                    memInfo.CivilStatus = civilStatusCombo.SelectedIndex;
                    memInfo.School = schoolCombo.SelectedValue == null ? -1 : (int)schoolCombo.SelectedValue;
                    memInfo.EduQualifications = eduQuaCombo.SelectedValue == null ? -1 : (int)eduQuaCombo.SelectedValue;
                    memInfo.Abilities = abilityText.Text;
                    memInfo.Contributition = contribText.Text;
                    memInfo.OtherQualifications = otheQualiText.Text;
                    memInfo.OccupatitioInfo = occuText.Text;
                    memInfo.Tags = new List<DBCore.Classes.Tag>();

                    if (tagGrid.Rows.Count > 0)
                    {

                        memInfo.Tags.Add(new Tag((int)tagGrid[2, 0].Value, "", "", 0));
                    }

                    switch (verifiedCheck.CheckState)
                    {
                        case CheckState.Checked:
                            {
                                memInfo.DataVerified = 1;
                                break;
                            }

                        case CheckState.Unchecked:
                            {
                                memInfo.DataVerified = 0;
                                break;
                            }

                        default:
                            {
                                memInfo.DataVerified = -1;
                                break;
                            }
                    }


                    if (indexText.Text == nextIndex)
                    {
                        memInfo.IndexNumber = string.Empty;
                    }
                    else
                    {
                        memInfo.IndexNumber = indexText.Text;
                    }

                    DataTable ds = memInfo.SelectFind();
                    frmSearch frmSub = new frmSearch(ds, this.Text, 18);

                    frmSub.Width = this.Width - 100;


                    if (HandleSearch(frmSub))
                    {
                        AddFindIDsToList(ds, 20);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageView.ExceptionError(ex);
            }
        }

        private void AddFindIDsToList(DataTable ds, int IDCell)
        {
            try
            {
                foreach (DataRow row in ds.Rows)
                {
                    int ID = Convert.ToInt32(row[IDCell]);
                    findIDList.Add(ID);

                    if (ID == memberID)
                        findListSelectedIndex = findIDList.Count - 1;
                }
            }
            catch { }
        }

        // hadle operations after search
        private bool HandleSearch(frmSearch frmSub)
        {
            //ApplicationSettings.ChildFormView(this.MdiParent, ref frmSub);
            if (frmSub.ShowDialog() == DialogResult.OK)
            {
                memberID = (int)frmSub.DataRowValues["ID"];
                FillSearchFilds(memberID);

                if (userLevel == DBCore.UserLevel.SystemAdmin || userLevel == DBCore.UserLevel.SystemUser_IUD)
                {
                    deleteBtn.Enabled = true;
                    addbtn.Text = "Update";
                }


                nextBtn.Visible = true;
                prevBtn.Visible = true;

                return true;
            }
            frmSub.Dispose();
            return false;
        }

        public void FillSearchFilds(int memberID)
        {
            try
            {
                this.memberID = memberID;

                using (MemberInfo memInfo = new MemberInfo(true, memberType))
                {
                    memInfo.SelectMember(memberID);

                    SetMemberFields(memInfo);
                }
            }
            catch (Exception ex)
            {
                MessageView.ExceptionError(ex);
            }
        }

        private void SetMemberFields(MemberInfo memInfo)
        {
            nicText.Text = memInfo.NIC;
            bloodGroupCombo.Text = memInfo.BloodGroup;
            nameTextBoxX.Text = memInfo.Name;
            addressTextbox.Text = memInfo.Address;
            dobDate.Value = memInfo.DOB;
            mobileText.Text = memInfo.Mobile;
            homeTpText.Text = memInfo.HomeTP;
            emailText.Text = memInfo.Email;
            occuCombo.SelectedValue = memInfo.Occupatition;
            occuText.Text = memInfo.OccupatitioInfo;
            dojoindate.Value = memInfo.DOJoinAsapuwa;
            abilityText.Text = memInfo.Abilities;
            contribText.Text = memInfo.Contributition;
            bloodGroupCombo.SelectedIndex = -1;
            bloodGroupCombo.Text = memInfo.BloodGroup;
            sexCombo.SelectedIndex = memInfo.Sex;
            civilStatusCombo.SelectedIndex = memInfo.CivilStatus;
            indexText.Text = memInfo.IndexNumber;
            //indexText.ReadOnly = true;
            schoolCombo.SelectedValue = memInfo.School;
            eduQuaCombo.SelectedValue = memInfo.EduQualifications;
            otheQualiText.Text = memInfo.OtherQualifications;
            verifiedCheck.CheckState = memInfo.DataVerified == 1 ? CheckState.Checked : CheckState.Unchecked;

            if (string.IsNullOrEmpty(memInfo.ImageData))
            {
                pictureBox.Image = null;
                imageData = null;
            }
            else
            {
                setPictureFromByteArray(Utility.GetByte64String(memInfo.ImageData));
            }

            setTags(memInfo.Tags);
        }


        private void setTags(List<Tag> list)
        {
            tagGrid.Rows.Clear();

            foreach (Tag tg in list)
            {
                AddTagGridRow(tg.MemberTagID, tg.Name,tg.ID);
            }
        }

        private void occueAddButton_Click(object sender, EventArgs e)
        {
            frmOccupatition occu = new frmOccupatition((int)userLevel);
            occu.ShowDialog();
            RefreshOccupationList();
        }

        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                OpenFileDialog fd = new OpenFileDialog();
                //  fd.Filter = "Image files|*.jpeg|*.jpg|*.png";
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    setPictureFromFile(fd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageView.ExceptionError(ex);
            }
        }


        private void setPictureFromFile(string fileName)
        {
            try
            {
                Image img = Image.FromFile(fileName);

                // set byte array
                MemoryStream mem = new MemoryStream();
                //  picDriverImage.Image.Save(mem, ImageFormat.Png);

                img.Save(mem, ImageFormat.Jpeg);
                imageData = mem.ToArray();

                if (imageData.Length > 512000)
                {
                    MessageView.ShowErrorMsg("Image is too large,Maximum size is 500KB");
                    imageData = null;
                    return;
                }


                pictureBox.Image = getThumbImage(img);
                img.Save("test.jpg", ImageFormat.Jpeg);

            }
            catch (Exception ex)
            {
                MessageView.ExceptionError(ex);
            }
        }

        private Image getThumbImage(Image image)
        {
            Image.GetThumbnailImageAbort del = new Image.GetThumbnailImageAbort(ThumbCallback);
            int thumbWidth = pictureBox.Width;
            int thumbHeight = pictureBox.Height;

            // set thumb images with and height, by considering actual image with and height ratio
            if (image.Width > image.Height)
            {
                thumbWidth = pictureBox.Width;
                thumbHeight = (int)Math.Round((image.Height / (float)image.Width) * pictureBox.Width);
            }
            else
            {
                thumbHeight = pictureBox.Height;
                thumbWidth = (int)Math.Round((image.Width / (float)image.Height) * pictureBox.Height);
            }

            return image.GetThumbnailImage(thumbWidth, thumbHeight, del, IntPtr.Zero);
        }


        public Image getThumbImageToSave(Image image)
        {
            Image.GetThumbnailImageAbort del = new Image.GetThumbnailImageAbort(ThumbCallback);
            int thumbWidth = 500;
            int thumbHeight = 500;

            // set thumb images with and height, by considering actual image with and height ratio
            if (image.Width > image.Height)
            {
                thumbWidth = 500;
                thumbHeight = (int)Math.Round((image.Height / (float)image.Width) * 500);
            }
            else
            {
                thumbHeight = 500;
                thumbWidth = (int)Math.Round((image.Width / (float)image.Height) * 500);
            }

            return image.GetThumbnailImage(thumbWidth, thumbHeight, del, IntPtr.Zero);
        }

        // use in SetImageData, for delegate
        private static bool ThumbCallback()
        {
            return false;
        }

        private void setPictureFromByteArray(byte[] picData)
        {
            try
            {
                if (picData == null)
                {
                    pictureBox.Image = null;
                    imageData = null;
                }
                else
                {
                    // set byte array
                    MemoryStream mem = new MemoryStream(picData);
                    imageData = picData;

                    Image img = Image.FromStream(mem);
                    pictureBox.Image = getThumbImage(img);
                }
            }
            catch (Exception ex)
            {
                MessageView.ExceptionError(ex);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageView.ShowQuestionMsg("Delete Image") == DialogResult.OK)
            {
                pictureBox.Image = null;
                imageData = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(GetASCII(emailText.Text));

            //MessageBox.Show(InputLanguage.InstalledInputLanguages[0].LayoutName + "\n" + InputLanguage.CurrentInputLanguage.LayoutName);

            //  InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[0];
            //InputLanguage.CurrentInputLanguage
        }


        public static string GetASCII(string unicodeString)
        {
            if (string.IsNullOrEmpty(unicodeString))
                return unicodeString;

            // Create two different encodings.
            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.Unicode;

            // Convert the string into a byte[].
            byte[] unicodeBytes = unicode.GetBytes(unicodeString);

            // Perform the conversion from one encoding to the other.
            byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);

            // Convert the new byte[] into a char[] and then into a string.
            // This is a slightly different approach to converting to illustrate
            // the use of GetCharCount/GetChars.
            char[] asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];
            ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
            string asciiString = new string(asciiChars);

            return asciiString.Replace("?", "_");
        }


        int possition = 0;

        private void emailText_KeyDown(object sender, KeyEventArgs e)
        {
            possition = emailText.SelectionStart;
            // emailText.SelectionLength = 0;

            emailText.Clear();
        }

        private void emailText_KeyUp(object sender, KeyEventArgs e)
        {



            emailString += Convert.ToChar(e.KeyValue).ToString().ToLower();
            emailText.Clear();
            emailText.Text = emailString;
            emailText.ForeColor = Color.Black;
            emailText.SelectionStart = possition + 1;
            // MessageBox.Show(possition.ToString());
        }

        private void emailText_KeyPress(object sender, KeyPressEventArgs e)
        {
            emailText.ForeColor = Color.White;
        }

        private void emailText_Enter(object sender, EventArgs e)
        {
            lan = InputLanguage.CurrentInputLanguage;
            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[0];
        }

        private void emailText_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = lan;
        }

        private void schoolAddBtn_Click(object sender, EventArgs e)
        {
            frmSchool sch = new frmSchool((int)userLevel);
            sch.ShowDialog();
            RefreshSchoolList();
        }

        private void eduQuabtn_Click(object sender, EventArgs e)
        {
            frmEduQualification edu = new frmEduQualification((int)userLevel);
            edu.ShowDialog();
            RefreshEduQualificationList();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (findListSelectedIndex - 1 > -1 && findIDList.Count > findListSelectedIndex - 1)
            {
                FillSearchFilds(findIDList[--findListSelectedIndex]);
            }

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {

            if (findListSelectedIndex + 1 > -1 && findIDList.Count > findListSelectedIndex + 1)
            {
                FillSearchFilds(findIDList[++findListSelectedIndex]);
            }


        }

        private void verifiedCheck_CheckedChanged(object sender, EventArgs e)
        {
            switch (verifiedCheck.CheckState)
            {
                case CheckState.Checked:
                    {
                        dataverifiedLabel.ForeColor = Color.Green;
                        break;
                    }

                case CheckState.Unchecked:
                    {
                        dataverifiedLabel.ForeColor = Color.Red;
                        break;
                    }

                default:
                    {
                        dataverifiedLabel.ForeColor = Color.Black;
                        break;
                    }
            }
        }

        private void frmMember_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 39 && nextBtn.Enabled)
            {
                nextBtn_Click(sender, e);
            }
            else if (e.KeyValue == 37 && prevBtn.Enabled)
            {
                prevBtn_Click(sender, e);
            }
        }

        private void addTagButton_Click(object sender, EventArgs e)
        {
            if (tagCombobox.SelectedIndex > -1)
            {
                int tagID = (int)tagCombobox.SelectedValue;

                if (checkExisting(tagID))
                {
                    if (memberID != 0)
                    {
                        using (MemberInfo info = new MemberInfo(true, memberType))
                        {
                            info.ID = memberID;


                            info.AddTag(tagID);
                        }
                    }

                    DataRowView item = (DataRowView)tagCombobox.SelectedItem;


                    AddTagGridRow(0, item.Row.ItemArray[1].ToString(), tagID);
                }
            }
        }

        private bool checkExisting(int tagID)
        {
            if (tagGrid.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in tagGrid.Rows)
                {
                    //DateTime fromDate = DateTime.Parse(row.Cells[3].Value.ToString());
                    //DateTime toDate = DateTime.Parse(row.Cells[4].Value.ToString());

                    if ((int)row.Cells[2].Value == tagID)
                        return false;

                }
            }

            return true;
        }

        private void AddTagGridRow(int id, string tagName, int tagID)
        {
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();

            cell1.Value = id;
            cell2.Value = tagName;
            cell3.Value = tagID;


            //  row.HeaderCell.Value = (otherDatagrid.Rows.Count + 1).ToString();
            row.Cells.Add(cell1);
            row.Cells.Add(cell2);
            row.Cells.Add(cell3);

            tagGrid.Rows.Add(row);
        }

        private void addNewTagButton_Click(object sender, EventArgs e)
        {
            frmTag tg = new frmTag((int)userLevel);
            tg.ShowDialog();
            RefreshTagList();
        }

        private void tagGrid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && tagGrid.CurrentRow.Index > -1)
            {
                if (MessageView.ShowQuestionMsg("Delete Current Tag '"+tagGrid.Rows[tagGrid.CurrentRow.Index].Cells[1].Value+"' ?") == System.Windows.Forms.DialogResult.OK)
                {
                    int id = (int)tagGrid.Rows[tagGrid.CurrentRow.Index].Cells[0].Value;
                    using (MemberInfo mem = new MemberInfo(true, memberType))
                    {
                        mem.RemoveMemberTag(id);
                    }

                    tagGrid.Rows.RemoveAt(tagGrid.CurrentRow.Index);
                }
            }
        }

        private void indexText_KeyUp(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
            {
                using (MemberInfo memInfo = new MemberInfo(true, memberType))
                {
                    if (indexText.Text != nextIndex)
                    {
                        memInfo.SelectMemberFromIndex(indexText.Text);

                        if (memInfo.IndexNumber == indexText.Text)
                        {
                            this.memberID = memInfo.ID;
                            SetMemberFields(memInfo);

                            if (userLevel == DBCore.UserLevel.SystemAdmin || userLevel == DBCore.UserLevel.SystemUser_IUD)
                            {
                                deleteBtn.Enabled = true;
                                addbtn.Text = "Update";
                            }

                        }
                        else
                        {
                            string tempIndex = indexText.Text;
                            clear();
                            indexText.Text = tempIndex;
                        }
                    }
                }
                indexText.SelectionStart = 15;
            }
        }

    }
}
