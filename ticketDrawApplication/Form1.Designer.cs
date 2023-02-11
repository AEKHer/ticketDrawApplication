namespace biletCekilisUygulaması
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtGiftName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTicketNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWinner = new Guna.UI2.WinForms.Guna2TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnStartDraw = new Guna.UI2.WinForms.Guna2Button();
            this.ticketConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.confirmWinners = new Guna.UI2.WinForms.Guna2Button();
            this.btnResults = new Guna.UI2.WinForms.Guna2Button();
            this.lblGft = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRemainingTicket = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.switchSelected = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.templistBox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(772, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.Size = new System.Drawing.Size(46, 45);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtGiftName
            // 
            this.txtGiftName.BorderRadius = 13;
            this.txtGiftName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiftName.DefaultText = "";
            this.txtGiftName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiftName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiftName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiftName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiftName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiftName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiftName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiftName.Location = new System.Drawing.Point(40, 257);
            this.txtGiftName.Name = "txtGiftName";
            this.txtGiftName.PasswordChar = '\0';
            this.txtGiftName.PlaceholderText = "";
            this.txtGiftName.SelectedText = "";
            this.txtGiftName.Size = new System.Drawing.Size(199, 30);
            this.txtGiftName.TabIndex = 1;
            this.txtGiftName.TextChanged += new System.EventHandler(this.txtGiftName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name of The Gift";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Ticket Number Size:";
            // 
            // txtTicketNumber
            // 
            this.txtTicketNumber.BorderRadius = 13;
            this.txtTicketNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTicketNumber.DefaultText = "";
            this.txtTicketNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTicketNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTicketNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTicketNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTicketNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTicketNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTicketNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTicketNumber.Location = new System.Drawing.Point(40, 130);
            this.txtTicketNumber.Name = "txtTicketNumber";
            this.txtTicketNumber.PasswordChar = '\0';
            this.txtTicketNumber.PlaceholderText = "";
            this.txtTicketNumber.SelectedText = "";
            this.txtTicketNumber.Size = new System.Drawing.Size(219, 30);
            this.txtTicketNumber.TabIndex = 3;
            this.txtTicketNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTicketNumber_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(49, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of Winneres:";
            // 
            // txtWinner
            // 
            this.txtWinner.BorderRadius = 13;
            this.txtWinner.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWinner.DefaultText = "";
            this.txtWinner.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWinner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWinner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWinner.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWinner.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWinner.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWinner.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWinner.Location = new System.Drawing.Point(40, 317);
            this.txtWinner.Name = "txtWinner";
            this.txtWinner.PasswordChar = '\0';
            this.txtWinner.PlaceholderText = "";
            this.txtWinner.SelectedText = "";
            this.txtWinner.Size = new System.Drawing.Size(199, 30);
            this.txtWinner.TabIndex = 5;
            this.txtWinner.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWinner_KeyPress);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(278, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 304);
            this.listBox1.TabIndex = 7;
            // 
            // btnStartDraw
            // 
            this.btnStartDraw.BorderRadius = 20;
            this.btnStartDraw.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartDraw.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartDraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartDraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartDraw.Enabled = false;
            this.btnStartDraw.FillColor = System.Drawing.Color.Turquoise;
            this.btnStartDraw.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStartDraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStartDraw.Location = new System.Drawing.Point(41, 366);
            this.btnStartDraw.Name = "btnStartDraw";
            this.btnStartDraw.Size = new System.Drawing.Size(180, 45);
            this.btnStartDraw.TabIndex = 8;
            this.btnStartDraw.Text = "Start Draw";
            this.btnStartDraw.Click += new System.EventHandler(this.btnStartDraw_Click);
            // 
            // ticketConfirm
            // 
            this.ticketConfirm.BorderRadius = 15;
            this.ticketConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ticketConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ticketConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ticketConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ticketConfirm.FillColor = System.Drawing.Color.Turquoise;
            this.ticketConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ticketConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ticketConfirm.Location = new System.Drawing.Point(40, 190);
            this.ticketConfirm.Name = "ticketConfirm";
            this.ticketConfirm.Size = new System.Drawing.Size(219, 33);
            this.ticketConfirm.TabIndex = 10;
            this.ticketConfirm.Text = "Confirm";
            this.ticketConfirm.Click += new System.EventHandler(this.ticketConfirm_Click);
            // 
            // confirmWinners
            // 
            this.confirmWinners.BorderRadius = 20;
            this.confirmWinners.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.confirmWinners.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.confirmWinners.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.confirmWinners.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.confirmWinners.Enabled = false;
            this.confirmWinners.FillColor = System.Drawing.Color.DarkCyan;
            this.confirmWinners.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirmWinners.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.confirmWinners.Location = new System.Drawing.Point(40, 417);
            this.confirmWinners.Name = "confirmWinners";
            this.confirmWinners.Size = new System.Drawing.Size(180, 45);
            this.confirmWinners.TabIndex = 11;
            this.confirmWinners.Text = "Confirm Winners and Start   a New Round";
            this.confirmWinners.Click += new System.EventHandler(this.confirmWinners_Click);
            // 
            // btnResults
            // 
            this.btnResults.BorderRadius = 20;
            this.btnResults.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResults.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResults.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResults.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResults.Enabled = false;
            this.btnResults.FillColor = System.Drawing.Color.DarkCyan;
            this.btnResults.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResults.Location = new System.Drawing.Point(452, 440);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(180, 45);
            this.btnResults.TabIndex = 12;
            this.btnResults.Text = "Show Results";
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // lblGft
            // 
            this.lblGft.AutoSize = true;
            this.lblGft.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGft.Location = new System.Drawing.Point(275, 114);
            this.lblGft.Name = "lblGft";
            this.lblGft.Size = new System.Drawing.Size(61, 13);
            this.lblGft.TabIndex = 13;
            this.lblGft.Text = "Gift Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(159, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 45);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ticket Draw Application";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(33, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tickets Remaining:";
            // 
            // lblRemainingTicket
            // 
            this.lblRemainingTicket.AutoSize = true;
            this.lblRemainingTicket.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRemainingTicket.Location = new System.Drawing.Point(206, 474);
            this.lblRemainingTicket.Name = "lblRemainingTicket";
            this.lblRemainingTicket.Size = new System.Drawing.Size(22, 25);
            this.lblRemainingTicket.TabIndex = 16;
            this.lblRemainingTicket.Text = "0";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.AutoSize = true;
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2GradientPanel1.Controls.Add(this.btnExit);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Teal;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Cyan;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(830, 106);
            this.guna2GradientPanel1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(306, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "By: Abdurrahman Ebrar- @aekher58";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // switchSelected
            // 
            this.switchSelected.CheckedState.BorderColor = System.Drawing.Color.Cyan;
            this.switchSelected.CheckedState.BorderRadius = 10;
            this.switchSelected.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.switchSelected.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchSelected.CheckedState.InnerColor = System.Drawing.Color.White;
            this.switchSelected.Location = new System.Drawing.Point(224, 165);
            this.switchSelected.Margin = new System.Windows.Forms.Padding(2);
            this.switchSelected.Name = "switchSelected";
            this.switchSelected.Size = new System.Drawing.Size(35, 20);
            this.switchSelected.TabIndex = 19;
            this.switchSelected.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchSelected.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchSelected.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchSelected.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(37, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Selceted Can Be Re-Selected";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // templistBox
            // 
            this.templistBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.templistBox.FormattingEnabled = true;
            this.templistBox.ItemHeight = 30;
            this.templistBox.Location = new System.Drawing.Point(543, 128);
            this.templistBox.Name = "templistBox";
            this.templistBox.Size = new System.Drawing.Size(259, 304);
            this.templistBox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(543, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Available Tickets:";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::ticketDrawApplication.Properties.Resources.ticket;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(38, 8);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(97, 95);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 15;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 517);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.templistBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.switchSelected);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.lblRemainingTicket);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblGft);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.confirmWinners);
            this.Controls.Add(this.ticketConfirm);
            this.Controls.Add(this.btnStartDraw);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWinner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTicketNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGiftName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Çekiliş Uygulaması";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnStartDraw;
        private System.Windows.Forms.ListBox listBox1;
        public Guna.UI2.WinForms.Guna2TextBox txtGiftName;
        public Guna.UI2.WinForms.Guna2TextBox txtWinner;
        public Guna.UI2.WinForms.Guna2TextBox txtTicketNumber;
        private Guna.UI2.WinForms.Guna2Button ticketConfirm;
        private System.Windows.Forms.Label lblGft;
        private Guna.UI2.WinForms.Guna2Button btnResults;
        public Guna.UI2.WinForms.Guna2Button confirmWinners;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRemainingTicket;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ToggleSwitch switchSelected;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.ListBox templistBox;
        private System.Windows.Forms.Label label8;
    }
}

