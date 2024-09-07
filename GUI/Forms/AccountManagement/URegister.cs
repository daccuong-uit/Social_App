using BLL;
using GUI.Resources.Styles;
using GUI.Utilities;
using Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Forms.AccountManagement
{
    public partial class URegister : UserControl
    {
        UserService _userService;
        EmailService _emailService;

        ComboBox cmbDay, cmbMonth, cmbYear;
        RadioButton rbMale, rbFemale, rbOther;

        public event EventHandler btnDarkmodeClicked;
        public event EventHandler btnGoToMainFormClicked;

        public URegister(UserService userService)
        {
            InitializeComponent();
            InitializeDateOfBirthComboBoxes();
            InitializeGenderRadioButton();

            ResetA();

            // Initialize UserService from the parameter
            _userService = userService;
            _emailService = new EmailService();
        }

        #region --> Noname

        #endregion

        #region -->  Design
        private void InitializeDateOfBirthComboBoxes()
        {
            // ComboBox cho ngày
            cmbDay = new ComboBox();
            cmbDay.Location = new Point(17, 10); // Vị trí ComboBox
            cmbDay.Size = new Size(144, 31); // Kích thước ComboBox
            cmbDay.DropDownHeight = 200; // Chiều cao danh sách khi mở
            cmbDay.MaxDropDownItems = 15; // Số item tối đa hiển thị trong danh sách
            cmbDay.Font = new Font("Georgia", 14);
            cmbDay.ForeColor = Color.Black;
            cmbDay.FlatStyle = FlatStyle.Flat;
            cmbDay.DropDownStyle = ComboBoxStyle.DropDownList; // Ngăn nhập văn bản

            // Thêm ngày vào ComboBox
            for (int day = 1; day <= 31; day++)
            {
                cmbDay.Items.Add(day);
            }
            panel6.Controls.Add(cmbDay);
            cmbDay.BringToFront();

            // Đăng ký sự kiện để mở hộp chọn
            cmbDay.Click += (s, e) => cmbDay.DroppedDown = true;
            cmbDay.Enter += (s, e) => cmbDay.DroppedDown = true;

            // ComboBox cho tháng
            cmbMonth = new ComboBox();
            cmbMonth.Location = new Point(17, 10); // Vị trí ComboBox
            cmbMonth.Size = new Size(144, 31); // Kích thước ComboBox
            cmbMonth.DropDownHeight = 200; // Chiều cao danh sách khi mở
            cmbMonth.MaxDropDownItems = 15; // Số item tối đa hiển thị trong danh sách
            cmbMonth.Font = new Font("Georgia", 14);
            cmbMonth.ForeColor = Color.Black;
            cmbMonth.FlatStyle = FlatStyle.Flat;
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList; // Ngăn nhập văn bản

            // Thêm tháng vào ComboBox
            for (int month = 1; month <= 12; month++)
            {
                cmbMonth.Items.Add(month);
            }
            panel7.Controls.Add(cmbMonth);
            cmbMonth.BringToFront();

            // Đăng ký sự kiện để mở hộp chọn
            cmbMonth.Click += (s, e) => cmbMonth.DroppedDown = true;
            cmbMonth.Enter += (s, e) => cmbMonth.DroppedDown = true;

            // ComboBox cho năm
            cmbYear = new ComboBox();
            cmbYear.Location = new Point(17, 10); // Vị trí ComboBox
            cmbYear.Size = new Size(144, 31); // Kích thước ComboBox
            cmbYear.DropDownHeight = 200; // Chiều cao danh sách khi mở
            cmbYear.MaxDropDownItems = 15; // Số item tối đa hiển thị trong danh sách
            cmbYear.Font = new Font("Georgia", 14);
            cmbYear.ForeColor = Color.Black;
            cmbYear.FlatStyle = FlatStyle.Flat;
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList; // Ngăn nhập văn bản

            // Thêm năm vào ComboBox
            for (int year = DateTime.Now.Year; year >= 1900; year--)
            {
                cmbYear.Items.Add(year);
            }
            panel8.Controls.Add(cmbYear);
            cmbYear.BringToFront();

            // Đăng ký sự kiện để mở hộp chọn
            cmbYear.Click += (s, e) => cmbYear.DroppedDown = true;
            cmbYear.Enter += (s, e) => cmbYear.DroppedDown = true;
        }

        private void InitializeGenderRadioButton()
        {
            rbMale = new RadioButton();
            rbOther = new RadioButton();
            rbFemale = new RadioButton();

            // Tạo RadioButton cho Male
            rbMale.Text = "Male";
            rbMale.Location = new Point(17, 10); // Vị trí RadioButton
            rbMale.Font = new Font("Georgia", 14);
            rbMale.ForeColor = Color.Black;
            rbMale.AutoSize = true; // Tự động điều chỉnh kích thước theo văn bản

            // Đăng ký sự kiện CheckedChanged cho Male
            rbMale.CheckedChanged += (s, e) =>
            {
                if (rbMale.Checked)
                {
                    rbFemale.Checked = false;
                    rbOther.Checked = false;
                }
            };

            panel9.Controls.Add(rbMale);
            rbMale.BringToFront();

            // Tạo RadioButton cho Female
            rbFemale.Text = "Female";
            rbFemale.Location = new Point(17, 10); // Vị trí RadioButton
            rbFemale.Font = new Font("Georgia", 14);
            rbFemale.ForeColor = Color.Black;
            rbFemale.AutoSize = true; // Tự động điều chỉnh kích thước theo văn bản

            // Đăng ký sự kiện CheckedChanged cho Female
            rbFemale.CheckedChanged += (s, e) =>
            {
                if (rbFemale.Checked)
                {
                    rbMale.Checked = false;
                    rbOther.Checked = false;
                }
            };

            panel10.Controls.Add(rbFemale);
            rbFemale.BringToFront();

            // Tạo RadioButton cho Other
            rbOther.Text = "Other";
            rbOther.Location = new Point(17, 10); // Vị trí RadioButton
            rbOther.Font = new Font("Georgia", 14);
            rbOther.ForeColor = Color.Black;
            rbOther.AutoSize = true; // Tự động điều chỉnh kích thước theo văn bản

            // Đăng ký sự kiện CheckedChanged cho Other
            rbOther.CheckedChanged += (s, e) =>
            {
                if (rbOther.Checked)
                {
                    rbMale.Checked = false;
                    rbFemale.Checked = false;
                }
            };

            panel11.Controls.Add(rbOther);
            rbOther.BringToFront();
        }
        void ResetA()
        {
            if (AppSettings.IsDarkMode)
            {
                cbtnDarkmode.Checked = true;
            }
            else
            {
                cbtnDarkmode.Checked = false;
            }
            txtPassword.PasswordChar = '●';
        }

        private void borUserName_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();
            lblUsename.SendToBack();
            txtUsername.BringToFront();
            //btnFirstnameClicked?.Invoke(this, EventArgs.Empty);
            borUserName.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }

        private void lblUsename_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();
            lblUsename.SendToBack();
            txtUsername.BringToFront();
            //btnFirstnameClicked?.Invoke(this, EventArgs.Empty);
            borUserName.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }

        private void lblLastName_Click(object sender, EventArgs e)
        {
            txtLastName.Focus();
            lblLastName.SendToBack();
            txtLastName.BringToFront();
            //btnLastnameClicked?.Invoke(this, EventArgs.Empty);
            borderLastname.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }

        private void borderCustome1_Click(object sender, EventArgs e)
        {
            txtLastName.Focus();
            lblLastName.SendToBack();
            txtLastName.BringToFront();
            //btnLastnameClicked?.Invoke(this, EventArgs.Empty);
            borderLastname.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            txtEmail.Focus();
            lblEmail.SendToBack();
            txtEmail.BringToFront();
            //btnEmailClicked?.Invoke(this, EventArgs.Empty);
            borderEmail.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }

        private void borderCustome2_Click(object sender, EventArgs e)
        {
            txtEmail.Focus();
            lblEmail.SendToBack();
            txtEmail.BringToFront();
            //btnEmailClicked?.Invoke(this, EventArgs.Empty);
            borderEmail.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
            lblPasssword.SendToBack();
            txtPassword.BringToFront();
            //btnPasswwordClicked?.Invoke(this, EventArgs.Empty);
            borderPass.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }

        private void borderCustome4_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
            lblPasssword.SendToBack();
            txtPassword.BringToFront();
            //btnPasswwordClicked?.Invoke(this, EventArgs.Empty);
            borderPass.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô nhập liệu rỗng
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.SendToBack();
                lblUsename.BringToFront();
            }
            if (Helpers.ValidateUsername(txtUsername.Text))
            {
                borUserName.BorderColor = ColorPalette.LightColor2;
            }
            else
            {
                borUserName.BorderColor = Color.Red;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô nhập liệu rỗng
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.SendToBack();
                lblEmail.BringToFront();
            }
            if (Helpers.IsValidEmail(txtEmail.Text))
            {
                borderEmail.BorderColor = ColorPalette.LightColor2;
            }
            else
            {
                borderEmail.BorderColor = Color.Red;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô nhập liệu rỗng
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.SendToBack();
                lblPasssword.BringToFront();
            }
            if (Helpers.ValidatePassword(txtPassword.Text))
            {
                borderPass.BorderColor = ColorPalette.LightColor2;
            }
            else
            {
                borderPass.BorderColor = Color.Red;
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô nhập liệu rỗng
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                txtLastName.SendToBack();
                lblLastName.BringToFront();
            }
            borderLastname.BorderColor = ColorPalette.LightColor2;
        }


        private void txtEnterOTP_Leave(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô nhập liệu rỗng
            if (string.IsNullOrWhiteSpace(txtEnterOTP.Text))
            {
                lblOTPEnter.BringToFront();
            }
            borOTP.BorderColor = ColorPalette.LightColor2;
        }

        private void lblOTPEnter_Click(object sender, EventArgs e)
        {
            txtEnterOTP.Focus();
            lblOTPEnter.SendToBack();
            txtEnterOTP.BringToFront();
            borOTP.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }

        private void borOTP_Click(object sender, EventArgs e)
        {
            txtEnterOTP.Focus();
            lblOTPEnter.SendToBack();
            txtEnterOTP.BringToFront();
            borOTP.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }
        #endregion

        #region --> Appsettings
        private void cbtnDarkmode_CheckedChanged(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái chế độ tối
            if (cbtnDarkmode.Checked) // Nếu CheckBox được chọn
            {
                AppSettings.IsDarkMode = false; // Tắt chế độ tối
            }
            else
            {
                AppSettings.IsDarkMode = true; // Bật chế độ tối
            }

            // Gọi sự kiện nút
            btnDarkmodeClicked?.Invoke(this, EventArgs.Empty);

            // Lưu cài đặt
            AppSettings.SaveSettings(); // Lưu cài đặt
        }
        #endregion

        #region --> Logic
        // Send OTP register email
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            string otp = _emailService.SendEmail(email);

            MessageBox.Show("Email sent successfully! " + otp, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Update UI visibility
            pnlEnterEmail.Visible = false;
            pnlOTPCode.Visible = true;
        }

        private void btnCancelOTP_Click(object sender, EventArgs e)
        {
            pnlEnterEmail.Visible = true;
            pnlOTPCode.Visible = false;
        }

        // Register
        private void btnNExtOtp_Click(object sender, EventArgs e)
        {
            SignUpAction();
            btnGoToMainFormClicked?.Invoke(sender, EventArgs.Empty);
        }
        private async void SignUpAction()
        {
            // Validate user input
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Email và mật khẩu không được để trống.");
                return;
            }

            // Retrieve date of birth and gender
            var (dateOfBirth, gender) = GetUserDetails();

            User user = new User
            {
                EmailAddress = txtEmail.Text,
                PhoneNumber = " ",
                FirstName = txtUsername.Text,
                LastName = txtLastName.Text,
                Password = txtPassword.Text
            };

            Profile profile = new Profile
            {
                FirstName = txtUsername.Text,
                LastName = txtLastName.Text,
                DateOfBirth = dateOfBirth,
                Gender = gender,
                Country = " ",
                AvatarPhoto = " ",
                CoverPhoto = " ",
                Bio = " "
            };

            try
            {
                await _userService.RegisterUserAsync(user, profile);
                MessageBox.Show("Đăng ký thành công!");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Thông báo: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private (DateTime dateOfBirth, string gender) GetUserDetails()
        {
            // Retrieve selected day, month, year from combo boxes
            int day = (int)cmbDay.SelectedItem; // Assuming cmbDay is accessible from this context
            int month = (int)cmbMonth.SelectedItem; // Assuming cmbMonth is accessible from this context
            int year = (int)cmbYear.SelectedItem; // Assuming cmbYear is accessible from this context

            // Create a DateTime object for the date of birth
            DateTime dateOfBirth = new DateTime(year, month, day);

            // Retrieve selected gender
            string gender = GetSelectedGender();

            return (dateOfBirth, gender);
        }

        private string GetSelectedGender()
        {
            if (rbMale.Checked)
            {
                return "Male";
            }
            else if (rbFemale.Checked)
            {
                return "Female";
            }
            else if (rbOther.Checked)
            {
                return "Other";
            }
            return "Not Specified";
        }
        #endregion
    }
}
