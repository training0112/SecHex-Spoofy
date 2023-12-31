namespace SecHex_GUI
{
    partial class Spoofy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spoofy));
            disk = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            mac = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            pcname = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            winid = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            HwProfile = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            display = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            efi = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            sm = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            req = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            spoofall = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            product = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            backup = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            systemcleaner = new MetroFramework.Controls.MetroCheckBox();
            logwind = new MetroFramework.Controls.MetroCheckBox();
            lgbt = new MetroFramework.Controls.MetroCheckBox();
            BIOSReleaseDate = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            MachineId = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            label1 = new Label();
            poeclearner = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            SuspendLayout();
            // 
            // disk
            // 
            disk.Animated = true;
            disk.AutoRoundedCorners = true;
            disk.BackColor = Color.Transparent;
            disk.BorderColor = Color.White;
            disk.BorderRadius = 17;
            disk.BorderThickness = 1;
            disk.CustomBorderColor = Color.Transparent;
            disk.DisabledState.BorderColor = Color.DarkGray;
            disk.DisabledState.CustomBorderColor = Color.DarkGray;
            disk.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            disk.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            disk.FillColor = Color.Transparent;
            disk.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            disk.ForeColor = Color.White;
            disk.Location = new Point(175, 137);
            disk.Name = "disk";
            disk.PressedDepth = 60;
            disk.ShadowDecoration.Depth = 50;
            disk.Size = new Size(157, 36);
            disk.TabIndex = 2;
            disk.Text = "DISK";
            disk.Click += disk_Click;
            // 
            // mac
            // 
            mac.Animated = true;
            mac.AutoRoundedCorners = true;
            mac.BackColor = Color.Transparent;
            mac.BorderColor = Color.White;
            mac.BorderRadius = 17;
            mac.BorderThickness = 1;
            mac.CustomBorderColor = Color.Transparent;
            mac.DisabledState.BorderColor = Color.DarkGray;
            mac.DisabledState.CustomBorderColor = Color.DarkGray;
            mac.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            mac.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            mac.FillColor = Color.Transparent;
            mac.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mac.ForeColor = Color.White;
            mac.Location = new Point(12, 94);
            mac.Name = "mac";
            mac.PressedDepth = 60;
            mac.Size = new Size(157, 36);
            mac.TabIndex = 4;
            mac.Text = "MAC";
            mac.Click += mac_Click;
            // 
            // pcname
            // 
            pcname.Animated = true;
            pcname.AutoRoundedCorners = true;
            pcname.BackColor = Color.Transparent;
            pcname.BorderColor = Color.White;
            pcname.BorderRadius = 17;
            pcname.BorderThickness = 1;
            pcname.CustomBorderColor = Color.Transparent;
            pcname.DisabledState.BorderColor = Color.DarkGray;
            pcname.DisabledState.CustomBorderColor = Color.DarkGray;
            pcname.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            pcname.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            pcname.FillColor = Color.Transparent;
            pcname.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pcname.ForeColor = Color.White;
            pcname.Location = new Point(338, 94);
            pcname.Name = "pcname";
            pcname.PressedDepth = 60;
            pcname.Size = new Size(157, 36);
            pcname.TabIndex = 5;
            pcname.Text = "PC-Name";
            pcname.Click += pcname_Click;
            // 
            // winid
            // 
            winid.Animated = true;
            winid.AutoRoundedCorners = true;
            winid.BackColor = Color.Transparent;
            winid.BorderColor = Color.White;
            winid.BorderRadius = 17;
            winid.BorderThickness = 1;
            winid.CustomBorderColor = Color.Transparent;
            winid.DisabledState.BorderColor = Color.DarkGray;
            winid.DisabledState.CustomBorderColor = Color.DarkGray;
            winid.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            winid.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            winid.FillColor = Color.Transparent;
            winid.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            winid.ForeColor = Color.White;
            winid.Location = new Point(175, 180);
            winid.Name = "winid";
            winid.PressedDepth = 60;
            winid.Size = new Size(157, 36);
            winid.TabIndex = 6;
            winid.Text = "Machine GUID";
            winid.Click += winid_Click;
            // 
            // HwProfile
            // 
            HwProfile.Animated = true;
            HwProfile.AutoRoundedCorners = true;
            HwProfile.BackColor = Color.Transparent;
            HwProfile.BorderColor = Color.White;
            HwProfile.BorderRadius = 17;
            HwProfile.BorderThickness = 1;
            HwProfile.CustomBorderColor = Color.Transparent;
            HwProfile.DisabledState.BorderColor = Color.DarkGray;
            HwProfile.DisabledState.CustomBorderColor = Color.DarkGray;
            HwProfile.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            HwProfile.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            HwProfile.FillColor = Color.Transparent;
            HwProfile.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            HwProfile.ForeColor = Color.White;
            HwProfile.Location = new Point(12, 223);
            HwProfile.Name = "HwProfile";
            HwProfile.PressedDepth = 60;
            HwProfile.Size = new Size(157, 36);
            HwProfile.TabIndex = 7;
            HwProfile.Text = "HwProfile GUID";
            HwProfile.Click += GUID_Click;
            // 
            // display
            // 
            display.Animated = true;
            display.AutoRoundedCorners = true;
            display.BackColor = Color.Transparent;
            display.BorderColor = Color.White;
            display.BorderRadius = 17;
            display.BorderThickness = 1;
            display.CustomBorderColor = Color.Transparent;
            display.DisabledState.BorderColor = Color.DarkGray;
            display.DisabledState.CustomBorderColor = Color.DarkGray;
            display.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            display.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            display.FillColor = Color.Transparent;
            display.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            display.ForeColor = Color.White;
            display.Location = new Point(175, 94);
            display.Name = "display";
            display.PressedDepth = 60;
            display.Size = new Size(157, 36);
            display.TabIndex = 8;
            display.Text = "Display ID";
            display.Click += display_Click;
            // 
            // efi
            // 
            efi.Animated = true;
            efi.AutoRoundedCorners = true;
            efi.BackColor = Color.Transparent;
            efi.BorderColor = Color.White;
            efi.BorderRadius = 17;
            efi.BorderThickness = 1;
            efi.CustomBorderColor = Color.Transparent;
            efi.DisabledState.BorderColor = Color.DarkGray;
            efi.DisabledState.CustomBorderColor = Color.DarkGray;
            efi.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            efi.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            efi.FillColor = Color.Transparent;
            efi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            efi.ForeColor = Color.White;
            efi.Location = new Point(338, 137);
            efi.Name = "efi";
            efi.PressedDepth = 60;
            efi.Size = new Size(157, 36);
            efi.TabIndex = 9;
            efi.Text = "EFI";
            efi.Click += efi_Click;
            // 
            // sm
            // 
            sm.Animated = true;
            sm.AutoRoundedCorners = true;
            sm.BackColor = Color.Transparent;
            sm.BorderColor = Color.White;
            sm.BorderRadius = 17;
            sm.BorderThickness = 1;
            sm.CustomBorderColor = Color.Transparent;
            sm.DisabledState.BorderColor = Color.DarkGray;
            sm.DisabledState.CustomBorderColor = Color.DarkGray;
            sm.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            sm.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            sm.FillColor = Color.Transparent;
            sm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sm.ForeColor = Color.White;
            sm.Location = new Point(12, 137);
            sm.Name = "sm";
            sm.PressedDepth = 60;
            sm.Size = new Size(157, 36);
            sm.TabIndex = 10;
            sm.Text = "SMBIOS";
            sm.Click += siticoneButton1_Click;
            // 
            // req
            // 
            req.Animated = true;
            req.AutoRoundedCorners = true;
            req.BackColor = Color.Transparent;
            req.BorderColor = Color.White;
            req.BorderRadius = 17;
            req.BorderThickness = 1;
            req.CustomBorderColor = Color.Transparent;
            req.DisabledState.BorderColor = Color.DarkGray;
            req.DisabledState.CustomBorderColor = Color.DarkGray;
            req.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            req.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            req.FillColor = Color.Transparent;
            req.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            req.ForeColor = Color.White;
            req.Location = new Point(12, 307);
            req.Name = "req";
            req.PressedDepth = 60;
            req.Size = new Size(483, 36);
            req.TabIndex = 11;
            req.Text = "Requirement Check";
            req.Click += req_Click;
            // 
            // spoofall
            // 
            spoofall.Animated = true;
            spoofall.AutoRoundedCorners = true;
            spoofall.BackColor = Color.Transparent;
            spoofall.BorderColor = Color.White;
            spoofall.BorderRadius = 17;
            spoofall.BorderThickness = 1;
            spoofall.CustomBorderColor = Color.Transparent;
            spoofall.DisabledState.BorderColor = Color.DarkGray;
            spoofall.DisabledState.CustomBorderColor = Color.DarkGray;
            spoofall.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            spoofall.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            spoofall.FillColor = Color.Transparent;
            spoofall.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            spoofall.ForeColor = Color.White;
            spoofall.Location = new Point(12, 351);
            spoofall.Name = "spoofall";
            spoofall.PressedDepth = 60;
            spoofall.Size = new Size(483, 36);
            spoofall.TabIndex = 17;
            spoofall.Text = "Spoof All";
            spoofall.Click += spoofall_Click;
            // 
            // product
            // 
            product.Animated = true;
            product.AutoRoundedCorners = true;
            product.BackColor = Color.Transparent;
            product.BorderColor = Color.White;
            product.BorderRadius = 17;
            product.BorderThickness = 1;
            product.CustomBorderColor = Color.Transparent;
            product.DisabledState.BorderColor = Color.DarkGray;
            product.DisabledState.CustomBorderColor = Color.DarkGray;
            product.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            product.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            product.FillColor = Color.Transparent;
            product.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            product.ForeColor = Color.White;
            product.Location = new Point(12, 180);
            product.Name = "product";
            product.PressedDepth = 60;
            product.Size = new Size(157, 36);
            product.TabIndex = 18;
            product.Text = "Product ID";
            product.Click += product_Click;
            // 
            // backup
            // 
            backup.Animated = true;
            backup.AutoRoundedCorners = true;
            backup.BackColor = Color.Transparent;
            backup.BorderColor = Color.White;
            backup.BorderRadius = 17;
            backup.BorderThickness = 1;
            backup.CustomBorderColor = Color.Transparent;
            backup.DisabledState.BorderColor = Color.DarkGray;
            backup.DisabledState.CustomBorderColor = Color.DarkGray;
            backup.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            backup.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            backup.FillColor = Color.Transparent;
            backup.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            backup.ForeColor = Color.White;
            backup.Location = new Point(338, 180);
            backup.Name = "backup";
            backup.PressedDepth = 60;
            backup.Size = new Size(157, 36);
            backup.TabIndex = 19;
            backup.Text = "BACKUP";
            backup.Click += backup_Click;
            // 
            // systemcleaner
            // 
            systemcleaner.AutoSize = true;
            systemcleaner.Location = new Point(12, 410);
            systemcleaner.Name = "systemcleaner";
            systemcleaner.Size = new Size(234, 15);
            systemcleaner.Style = MetroFramework.MetroColorStyle.Magenta;
            systemcleaner.TabIndex = 33;
            systemcleaner.Text = "System Cleaner + Anti Cheat Terminator";
            systemcleaner.Theme = MetroFramework.MetroThemeStyle.Dark;
            systemcleaner.UseVisualStyleBackColor = true;
            systemcleaner.CheckedChanged += systemcleaner_CheckedChanged;
            // 
            // logwind
            // 
            logwind.AutoSize = true;
            logwind.Location = new Point(12, 434);
            logwind.Name = "logwind";
            logwind.Size = new Size(93, 15);
            logwind.Style = MetroFramework.MetroColorStyle.Magenta;
            logwind.TabIndex = 34;
            logwind.Text = "LOG Window";
            logwind.Theme = MetroFramework.MetroThemeStyle.Dark;
            logwind.UseVisualStyleBackColor = true;
            logwind.CheckedChanged += logwind_CheckedChanged;
            // 
            // lgbt
            // 
            lgbt.AutoSize = true;
            lgbt.Location = new Point(12, 457);
            lgbt.Name = "lgbt";
            lgbt.Size = new Size(100, 15);
            lgbt.Style = MetroFramework.MetroColorStyle.Magenta;
            lgbt.TabIndex = 35;
            lgbt.Text = "LGBTQ+ Mode";
            lgbt.TextAlign = ContentAlignment.TopLeft;
            lgbt.Theme = MetroFramework.MetroThemeStyle.Dark;
            lgbt.UseVisualStyleBackColor = true;
            lgbt.CheckedChanged += lgbt_CheckedChanged;
            // 
            // BIOSReleaseDate
            // 
            BIOSReleaseDate.Animated = true;
            BIOSReleaseDate.AutoRoundedCorners = true;
            BIOSReleaseDate.BackColor = Color.Transparent;
            BIOSReleaseDate.BorderColor = Color.White;
            BIOSReleaseDate.BorderRadius = 17;
            BIOSReleaseDate.BorderThickness = 1;
            BIOSReleaseDate.CustomBorderColor = Color.Transparent;
            BIOSReleaseDate.DisabledState.BorderColor = Color.DarkGray;
            BIOSReleaseDate.DisabledState.CustomBorderColor = Color.DarkGray;
            BIOSReleaseDate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BIOSReleaseDate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BIOSReleaseDate.FillColor = Color.Transparent;
            BIOSReleaseDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BIOSReleaseDate.ForeColor = Color.White;
            BIOSReleaseDate.Location = new Point(338, 223);
            BIOSReleaseDate.Name = "BIOSReleaseDate";
            BIOSReleaseDate.PressedDepth = 60;
            BIOSReleaseDate.Size = new Size(157, 36);
            BIOSReleaseDate.TabIndex = 36;
            BIOSReleaseDate.Text = "BIOSReleaseDate";
            BIOSReleaseDate.Click += BIOSReleaseDate_Click;
            // 
            // MachineId
            // 
            MachineId.Animated = true;
            MachineId.AutoRoundedCorners = true;
            MachineId.BackColor = Color.Transparent;
            MachineId.BorderColor = Color.White;
            MachineId.BorderRadius = 17;
            MachineId.BorderThickness = 1;
            MachineId.CustomBorderColor = Color.Transparent;
            MachineId.DisabledState.BorderColor = Color.DarkGray;
            MachineId.DisabledState.CustomBorderColor = Color.DarkGray;
            MachineId.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            MachineId.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            MachineId.FillColor = Color.Transparent;
            MachineId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MachineId.ForeColor = Color.White;
            MachineId.Location = new Point(175, 224);
            MachineId.Name = "MachineId";
            MachineId.PressedDepth = 60;
            MachineId.Size = new Size(157, 36);
            MachineId.TabIndex = 37;
            MachineId.Text = "Machine ID";
            MachineId.Click += MachineId_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 192);
            label1.Location = new Point(12, 475);
            label1.Name = "label1";
            label1.Size = new Size(483, 20);
            label1.TabIndex = 38;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // poeclearner
            // 
            poeclearner.Animated = true;
            poeclearner.AutoRoundedCorners = true;
            poeclearner.BackColor = Color.Transparent;
            poeclearner.BorderColor = Color.White;
            poeclearner.BorderRadius = 17;
            poeclearner.BorderThickness = 1;
            poeclearner.CustomBorderColor = Color.Transparent;
            poeclearner.DisabledState.BorderColor = Color.DarkGray;
            poeclearner.DisabledState.CustomBorderColor = Color.DarkGray;
            poeclearner.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            poeclearner.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            poeclearner.FillColor = Color.Transparent;
            poeclearner.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            poeclearner.ForeColor = Color.White;
            poeclearner.Location = new Point(12, 265);
            poeclearner.Name = "poeclearner";
            poeclearner.PressedDepth = 60;
            poeclearner.Size = new Size(157, 36);
            poeclearner.TabIndex = 39;
            poeclearner.Text = "Poe Clearner";
            poeclearner.Click += ClearRegistryDataPoe_click;
            // 
            // Spoofy
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 17);
            ClientSize = new Size(510, 507);
            Controls.Add(poeclearner);
            Controls.Add(label1);
            Controls.Add(MachineId);
            Controls.Add(BIOSReleaseDate);
            Controls.Add(lgbt);
            Controls.Add(logwind);
            Controls.Add(systemcleaner);
            Controls.Add(backup);
            Controls.Add(product);
            Controls.Add(spoofall);
            Controls.Add(req);
            Controls.Add(sm);
            Controls.Add(efi);
            Controls.Add(display);
            Controls.Add(HwProfile);
            Controls.Add(winid);
            Controls.Add(pcname);
            Controls.Add(mac);
            Controls.Add(disk);
            ForeColor = Color.Gray;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Spoofy";
            Padding = new Padding(20, 68, 20, 23);
            Resizable = false;
            ShadowType = MetroFormShadowType.DropShadow;
            Style = MetroFramework.MetroColorStyle.Magenta;
            Text = "SecHex - Spoofy V1.5.8";
            Theme = MetroFramework.MetroThemeStyle.Dark;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton disk;
        private Siticone.Desktop.UI.WinForms.SiticoneButton mac;
        private Siticone.Desktop.UI.WinForms.SiticoneButton pcname;
        private Siticone.Desktop.UI.WinForms.SiticoneButton winid;
        private Siticone.Desktop.UI.WinForms.SiticoneButton HwProfile;
        private Siticone.Desktop.UI.WinForms.SiticoneButton display;
        private Siticone.Desktop.UI.WinForms.SiticoneButton efi;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sm;
        private Siticone.Desktop.UI.WinForms.SiticoneButton req;
        private Siticone.Desktop.UI.WinForms.SiticoneButton spoofall;
        private Siticone.Desktop.UI.WinForms.SiticoneButton product;
        private Siticone.Desktop.UI.WinForms.SiticoneButton backup;
        private MetroFramework.Controls.MetroCheckBox systemcleaner;
        private MetroFramework.Controls.MetroCheckBox logwind;
        private MetroFramework.Controls.MetroCheckBox lgbt;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BIOSReleaseDate;
        private Siticone.Desktop.UI.WinForms.SiticoneButton MachineId;
        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton poeclearner;
    }
}