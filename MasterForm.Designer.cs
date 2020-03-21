﻿using System.Drawing;

namespace MCC_Mod_Manager
{
    partial class MasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            this.topBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.version_lbl = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.PictureBox();
            this.minButton = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.betterPBar = new System.Windows.Forms.Panel();
            this.TabControl = new ModManagerCustomControls.CustomTabControl();
            this.MyModsTab = new System.Windows.Forms.TabPage();
            this.manualOverride = new System.Windows.Forms.CheckBox();
            this.selectEnabled_chb = new System.Windows.Forms.CheckBox();
            this.homeEnabledLabel = new System.Windows.Forms.Label();
            this.delModpack = new System.Windows.Forms.Button();
            this.patchButton = new System.Windows.Forms.Button();
            this.homeNameLabel = new System.Windows.Forms.Label();
            this.homeSelectLabel = new System.Windows.Forms.Label();
            this.modListPanel = new System.Windows.Forms.Panel();
            this.CreateModpackTab = new System.Windows.Forms.TabPage();
            this.modpackName_label = new System.Windows.Forms.Label();
            this.modpackName_txt = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addRowButton = new System.Windows.Forms.PictureBox();
            this.createModpackBtn = new System.Windows.Forms.Button();
            this.createLabel2 = new System.Windows.Forms.Label();
            this.createLabel1 = new System.Windows.Forms.Label();
            this.createFilesPanel = new System.Windows.Forms.Panel();
            this.ConfigurationTab = new System.Windows.Forms.TabPage();
            this.CreatedByLabel = new System.Windows.Forms.Label();
            this.resetApp = new System.Windows.Forms.Button();
            this.delOldBaks_chb = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cfgTextBox3 = new System.Windows.Forms.TextBox();
            this.cfgBrowseBtn3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cfgTextBox2 = new System.Windows.Forms.TextBox();
            this.cfgBrowseBtn2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cfgTextBox1 = new System.Windows.Forms.TextBox();
            this.cfgBrowseBtn1 = new System.Windows.Forms.Button();
            this.configLabel3 = new System.Windows.Forms.Label();
            this.configLabel2 = new System.Windows.Forms.Label();
            this.cfgUpdateBtn = new System.Windows.Forms.Button();
            this.configLabel1 = new System.Windows.Forms.Label();
            this.BackupsTab = new System.Windows.Forms.TabPage();
            this.fullBakPath_chb = new System.Windows.Forms.CheckBox();
            this.restoreSelectedBtn = new System.Windows.Forms.Button();
            this.delAllBaksBtn = new System.Windows.Forms.Button();
            this.makeBakBtn = new System.Windows.Forms.Button();
            this.restoreAllBaksBtn = new System.Windows.Forms.Button();
            this.delSelectedBak = new System.Windows.Forms.Button();
            this.bakLabel2 = new System.Windows.Forms.Label();
            this.bakLabel1 = new System.Windows.Forms.Label();
            this.bakListPanel = new System.Windows.Forms.Panel();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.TabControl.SuspendLayout();
            this.MyModsTab.SuspendLayout();
            this.CreateModpackTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addRowButton)).BeginInit();
            this.ConfigurationTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.BackupsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.DarkGray;
            this.topBar.Controls.Add(this.pictureBox1);
            this.topBar.Controls.Add(this.version_lbl);
            this.topBar.Controls.Add(this.refreshButton);
            this.topBar.Controls.Add(this.minButton);
            this.topBar.Controls.Add(this.titleLabel);
            this.topBar.Controls.Add(this.exitButton);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(577, 37);
            this.topBar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MCC_Mod_Manager.Properties.Resources.HaloHelmetIcon_small;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 44);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // version_lbl
            // 
            this.version_lbl.AutoSize = true;
            this.version_lbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.version_lbl.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version_lbl.Location = new System.Drawing.Point(429, 9);
            this.version_lbl.Name = "version_lbl";
            this.version_lbl.Size = new System.Drawing.Size(39, 19);
            this.version_lbl.TabIndex = 6;
            this.version_lbl.Text = "v???";
            this.version_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.Location = new System.Drawing.Point(473, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(30, 30);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.TabStop = false;
            // 
            // minButton
            // 
            this.minButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minButton.Image = ((System.Drawing.Image)(resources.GetObject("minButton.Image")));
            this.minButton.Location = new System.Drawing.Point(509, 3);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(30, 30);
            this.minButton.TabIndex = 4;
            this.minButton.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.titleLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(46, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(240, 19);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "MCC Mod Manager by MrFRZ0";
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(543, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 30);
            this.exitButton.TabIndex = 2;
            this.exitButton.TabStop = false;
            // 
            // betterPBar
            // 
            this.betterPBar.Location = new System.Drawing.Point(4, 448);
            this.betterPBar.Name = "betterPBar";
            this.betterPBar.Size = new System.Drawing.Size(570, 44);
            this.betterPBar.TabIndex = 10;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.MyModsTab);
            this.TabControl.Controls.Add(this.CreateModpackTab);
            this.TabControl.Controls.Add(this.ConfigurationTab);
            this.TabControl.Controls.Add(this.BackupsTab);
            this.TabControl.ItemSize = new System.Drawing.Size(116, 20);
            this.TabControl.Location = new System.Drawing.Point(0, 40);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(577, 402);
            this.TabControl.TabIndex = 11;
            // 
            // MyModsTab
            // 
            this.MyModsTab.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.MyModsTab.Controls.Add(this.manualOverride);
            this.MyModsTab.Controls.Add(this.selectEnabled_chb);
            this.MyModsTab.Controls.Add(this.homeEnabledLabel);
            this.MyModsTab.Controls.Add(this.delModpack);
            this.MyModsTab.Controls.Add(this.patchButton);
            this.MyModsTab.Controls.Add(this.homeNameLabel);
            this.MyModsTab.Controls.Add(this.homeSelectLabel);
            this.MyModsTab.Controls.Add(this.modListPanel);
            this.MyModsTab.Location = new System.Drawing.Point(0, 19);
            this.MyModsTab.Name = "MyModsTab";
            this.MyModsTab.Padding = new System.Windows.Forms.Padding(3);
            this.MyModsTab.Size = new System.Drawing.Size(577, 383);
            this.MyModsTab.TabIndex = 0;
            this.MyModsTab.Text = "My Mods";
            // 
            // manualOverride
            // 
            this.manualOverride.AutoSize = true;
            this.manualOverride.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualOverride.ForeColor = System.Drawing.Color.DarkRed;
            this.manualOverride.Location = new System.Drawing.Point(287, 14);
            this.manualOverride.Name = "manualOverride";
            this.manualOverride.Size = new System.Drawing.Size(132, 17);
            this.manualOverride.TabIndex = 16;
            this.manualOverride.Text = "Allow Manual Override";
            this.manualOverride.UseVisualStyleBackColor = true;
            // 
            // selectEnabled_chb
            // 
            this.selectEnabled_chb.AutoSize = true;
            this.selectEnabled_chb.Checked = true;
            this.selectEnabled_chb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.selectEnabled_chb.Location = new System.Drawing.Point(432, 248);
            this.selectEnabled_chb.Name = "selectEnabled_chb";
            this.selectEnabled_chb.Size = new System.Drawing.Size(98, 17);
            this.selectEnabled_chb.TabIndex = 15;
            this.selectEnabled_chb.Text = "Select Enabled";
            this.selectEnabled_chb.UseVisualStyleBackColor = true;
            // 
            // homeEnabledLabel
            // 
            this.homeEnabledLabel.AutoSize = true;
            this.homeEnabledLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.homeEnabledLabel.Location = new System.Drawing.Point(8, 8);
            this.homeEnabledLabel.Name = "homeEnabledLabel";
            this.homeEnabledLabel.Size = new System.Drawing.Size(53, 15);
            this.homeEnabledLabel.TabIndex = 14;
            this.homeEnabledLabel.Text = "Enabled";
            // 
            // delModpack
            // 
            this.delModpack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.delModpack.ForeColor = System.Drawing.Color.Red;
            this.delModpack.Location = new System.Drawing.Point(432, 312);
            this.delModpack.Name = "delModpack";
            this.delModpack.Size = new System.Drawing.Size(124, 35);
            this.delModpack.TabIndex = 13;
            this.delModpack.Text = "Delete Selected";
            this.delModpack.UseVisualStyleBackColor = true;
            // 
            // patchButton
            // 
            this.patchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.patchButton.Location = new System.Drawing.Point(432, 271);
            this.patchButton.Name = "patchButton";
            this.patchButton.Size = new System.Drawing.Size(124, 35);
            this.patchButton.TabIndex = 12;
            this.patchButton.Text = "Patch/Unpatch";
            this.patchButton.UseVisualStyleBackColor = true;
            // 
            // homeNameLabel
            // 
            this.homeNameLabel.AutoSize = true;
            this.homeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.homeNameLabel.Location = new System.Drawing.Point(110, 8);
            this.homeNameLabel.Name = "homeNameLabel";
            this.homeNameLabel.Size = new System.Drawing.Size(95, 15);
            this.homeNameLabel.TabIndex = 11;
            this.homeNameLabel.Text = "Modpack Name";
            // 
            // homeSelectLabel
            // 
            this.homeSelectLabel.AutoSize = true;
            this.homeSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.homeSelectLabel.Location = new System.Drawing.Point(62, 8);
            this.homeSelectLabel.Name = "homeSelectLabel";
            this.homeSelectLabel.Size = new System.Drawing.Size(41, 15);
            this.homeSelectLabel.TabIndex = 10;
            this.homeSelectLabel.Text = "Select";
            // 
            // modListPanel
            // 
            this.modListPanel.AutoScroll = true;
            this.modListPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.modListPanel.Location = new System.Drawing.Point(12, 34);
            this.modListPanel.Name = "modListPanel";
            this.modListPanel.Size = new System.Drawing.Size(407, 322);
            this.modListPanel.TabIndex = 9;
            // 
            // CreateModpackTab
            // 
            this.CreateModpackTab.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CreateModpackTab.Controls.Add(this.modpackName_label);
            this.CreateModpackTab.Controls.Add(this.modpackName_txt);
            this.CreateModpackTab.Controls.Add(this.clearBtn);
            this.CreateModpackTab.Controls.Add(this.addRowButton);
            this.CreateModpackTab.Controls.Add(this.createModpackBtn);
            this.CreateModpackTab.Controls.Add(this.createLabel2);
            this.CreateModpackTab.Controls.Add(this.createLabel1);
            this.CreateModpackTab.Controls.Add(this.createFilesPanel);
            this.CreateModpackTab.Location = new System.Drawing.Point(0, 21);
            this.CreateModpackTab.Name = "CreateModpackTab";
            this.CreateModpackTab.Padding = new System.Windows.Forms.Padding(3);
            this.CreateModpackTab.Size = new System.Drawing.Size(577, 381);
            this.CreateModpackTab.TabIndex = 1;
            this.CreateModpackTab.Text = "Create Modpack";
            // 
            // modpackName_label
            // 
            this.modpackName_label.AutoSize = true;
            this.modpackName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.modpackName_label.Location = new System.Drawing.Point(11, 301);
            this.modpackName_label.Name = "modpackName_label";
            this.modpackName_label.Size = new System.Drawing.Size(95, 15);
            this.modpackName_label.TabIndex = 17;
            this.modpackName_label.Text = "Modpack Name";
            // 
            // modpackName_txt
            // 
            this.modpackName_txt.Location = new System.Drawing.Point(14, 326);
            this.modpackName_txt.Name = "modpackName_txt";
            this.modpackName_txt.Size = new System.Drawing.Size(288, 20);
            this.modpackName_txt.TabIndex = 16;
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.clearBtn.Location = new System.Drawing.Point(434, 317);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(120, 35);
            this.clearBtn.TabIndex = 15;
            this.clearBtn.Text = "Clear All";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // addRowButton
            // 
            this.addRowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addRowButton.Image = ((System.Drawing.Image)(resources.GetObject("addRowButton.Image")));
            this.addRowButton.Location = new System.Drawing.Point(10, 6);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(25, 25);
            this.addRowButton.TabIndex = 14;
            this.addRowButton.TabStop = false;
            // 
            // createModpackBtn
            // 
            this.createModpackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.createModpackBtn.Location = new System.Drawing.Point(308, 317);
            this.createModpackBtn.Name = "createModpackBtn";
            this.createModpackBtn.Size = new System.Drawing.Size(120, 35);
            this.createModpackBtn.TabIndex = 13;
            this.createModpackBtn.Text = "Create Modpack";
            this.createModpackBtn.UseVisualStyleBackColor = true;
            // 
            // createLabel2
            // 
            this.createLabel2.AutoSize = true;
            this.createLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.createLabel2.Location = new System.Drawing.Point(356, 13);
            this.createLabel2.Name = "createLabel2";
            this.createLabel2.Size = new System.Drawing.Size(69, 15);
            this.createLabel2.TabIndex = 12;
            this.createLabel2.Text = "Destination";
            // 
            // createLabel1
            // 
            this.createLabel1.AutoSize = true;
            this.createLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.createLabel1.Location = new System.Drawing.Point(94, 13);
            this.createLabel1.Name = "createLabel1";
            this.createLabel1.Size = new System.Drawing.Size(76, 15);
            this.createLabel1.TabIndex = 11;
            this.createLabel1.Text = "Modded File";
            // 
            // createFilesPanel
            // 
            this.createFilesPanel.AutoScroll = true;
            this.createFilesPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.createFilesPanel.Location = new System.Drawing.Point(10, 39);
            this.createFilesPanel.Name = "createFilesPanel";
            this.createFilesPanel.Size = new System.Drawing.Size(536, 259);
            this.createFilesPanel.TabIndex = 10;
            // 
            // ConfigurationTab
            // 
            this.ConfigurationTab.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ConfigurationTab.Controls.Add(this.CreatedByLabel);
            this.ConfigurationTab.Controls.Add(this.resetApp);
            this.ConfigurationTab.Controls.Add(this.delOldBaks_chb);
            this.ConfigurationTab.Controls.Add(this.panel3);
            this.ConfigurationTab.Controls.Add(this.panel2);
            this.ConfigurationTab.Controls.Add(this.panel1);
            this.ConfigurationTab.Controls.Add(this.configLabel3);
            this.ConfigurationTab.Controls.Add(this.configLabel2);
            this.ConfigurationTab.Controls.Add(this.cfgUpdateBtn);
            this.ConfigurationTab.Controls.Add(this.configLabel1);
            this.ConfigurationTab.Location = new System.Drawing.Point(0, 19);
            this.ConfigurationTab.Name = "ConfigurationTab";
            this.ConfigurationTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConfigurationTab.Size = new System.Drawing.Size(577, 383);
            this.ConfigurationTab.TabIndex = 2;
            this.ConfigurationTab.Text = "Configuration";
            // 
            // CreatedByLabel
            // 
            this.CreatedByLabel.AutoSize = true;
            this.CreatedByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CreatedByLabel.Location = new System.Drawing.Point(39, 325);
            this.CreatedByLabel.Name = "CreatedByLabel";
            this.CreatedByLabel.Size = new System.Drawing.Size(296, 13);
            this.CreatedByLabel.TabIndex = 62;
            this.CreatedByLabel.Text = "Created and built by MrFRZ0 ~ Enhancements by Darksound";
            // 
            // resetApp
            // 
            this.resetApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.resetApp.ForeColor = System.Drawing.Color.Red;
            this.resetApp.Location = new System.Drawing.Point(299, 260);
            this.resetApp.Name = "resetApp";
            this.resetApp.Size = new System.Drawing.Size(96, 35);
            this.resetApp.TabIndex = 61;
            this.resetApp.Text = "Reset App";
            this.resetApp.UseVisualStyleBackColor = true;
            // 
            // delOldBaks_chb
            // 
            this.delOldBaks_chb.AutoSize = true;
            this.delOldBaks_chb.Location = new System.Drawing.Point(226, 121);
            this.delOldBaks_chb.Name = "delOldBaks_chb";
            this.delOldBaks_chb.Size = new System.Drawing.Size(243, 17);
            this.delOldBaks_chb.TabIndex = 60;
            this.delOldBaks_chb.Text = "Delete backups after restoring? (saves space)";
            this.delOldBaks_chb.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cfgTextBox3);
            this.panel3.Controls.Add(this.cfgBrowseBtn3);
            this.panel3.Location = new System.Drawing.Point(42, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 31);
            this.panel3.TabIndex = 58;
            // 
            // cfgTextBox3
            // 
            this.cfgTextBox3.Location = new System.Drawing.Point(5, 3);
            this.cfgTextBox3.Name = "cfgTextBox3";
            this.cfgTextBox3.Size = new System.Drawing.Size(413, 20);
            this.cfgTextBox3.TabIndex = 11;
            // 
            // cfgBrowseBtn3
            // 
            this.cfgBrowseBtn3.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfgBrowseBtn3.Location = new System.Drawing.Point(423, 3);
            this.cfgBrowseBtn3.Name = "cfgBrowseBtn3";
            this.cfgBrowseBtn3.Size = new System.Drawing.Size(39, 20);
            this.cfgBrowseBtn3.TabIndex = 12;
            this.cfgBrowseBtn3.Text = "...";
            this.cfgBrowseBtn3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cfgBrowseBtn3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cfgTextBox2);
            this.panel2.Controls.Add(this.cfgBrowseBtn2);
            this.panel2.Location = new System.Drawing.Point(42, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 31);
            this.panel2.TabIndex = 59;
            // 
            // cfgTextBox2
            // 
            this.cfgTextBox2.Location = new System.Drawing.Point(5, 3);
            this.cfgTextBox2.Name = "cfgTextBox2";
            this.cfgTextBox2.Size = new System.Drawing.Size(413, 20);
            this.cfgTextBox2.TabIndex = 8;
            // 
            // cfgBrowseBtn2
            // 
            this.cfgBrowseBtn2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfgBrowseBtn2.Location = new System.Drawing.Point(423, 3);
            this.cfgBrowseBtn2.Name = "cfgBrowseBtn2";
            this.cfgBrowseBtn2.Size = new System.Drawing.Size(39, 20);
            this.cfgBrowseBtn2.TabIndex = 9;
            this.cfgBrowseBtn2.Text = "...";
            this.cfgBrowseBtn2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cfgBrowseBtn2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cfgTextBox1);
            this.panel1.Controls.Add(this.cfgBrowseBtn1);
            this.panel1.Location = new System.Drawing.Point(42, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 31);
            this.panel1.TabIndex = 57;
            // 
            // cfgTextBox1
            // 
            this.cfgTextBox1.Location = new System.Drawing.Point(5, 3);
            this.cfgTextBox1.Name = "cfgTextBox1";
            this.cfgTextBox1.Size = new System.Drawing.Size(412, 20);
            this.cfgTextBox1.TabIndex = 1;
            // 
            // cfgBrowseBtn1
            // 
            this.cfgBrowseBtn1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfgBrowseBtn1.Location = new System.Drawing.Point(423, 3);
            this.cfgBrowseBtn1.Name = "cfgBrowseBtn1";
            this.cfgBrowseBtn1.Size = new System.Drawing.Size(39, 20);
            this.cfgBrowseBtn1.TabIndex = 4;
            this.cfgBrowseBtn1.Text = "...";
            this.cfgBrowseBtn1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cfgBrowseBtn1.UseVisualStyleBackColor = true;
            // 
            // configLabel3
            // 
            this.configLabel3.AutoSize = true;
            this.configLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.configLabel3.Location = new System.Drawing.Point(42, 171);
            this.configLabel3.Name = "configLabel3";
            this.configLabel3.Size = new System.Drawing.Size(137, 13);
            this.configLabel3.TabIndex = 56;
            this.configLabel3.Text = "Modpack Storage Directory";
            // 
            // configLabel2
            // 
            this.configLabel2.AutoSize = true;
            this.configLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.configLabel2.Location = new System.Drawing.Point(42, 113);
            this.configLabel2.Name = "configLabel2";
            this.configLabel2.Size = new System.Drawing.Size(89, 13);
            this.configLabel2.TabIndex = 55;
            this.configLabel2.Text = "Backup Directory";
            // 
            // cfgUpdateBtn
            // 
            this.cfgUpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.cfgUpdateBtn.Location = new System.Drawing.Point(411, 260);
            this.cfgUpdateBtn.Name = "cfgUpdateBtn";
            this.cfgUpdateBtn.Size = new System.Drawing.Size(96, 35);
            this.cfgUpdateBtn.TabIndex = 54;
            this.cfgUpdateBtn.Text = "Update";
            this.cfgUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // configLabel1
            // 
            this.configLabel1.AutoSize = true;
            this.configLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.configLabel1.Location = new System.Drawing.Point(42, 55);
            this.configLabel1.Name = "configLabel1";
            this.configLabel1.Size = new System.Drawing.Size(105, 13);
            this.configLabel1.TabIndex = 53;
            this.configLabel1.Text = "MCC Install Directory";
            // 
            // BackupsTab
            // 
            this.BackupsTab.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackupsTab.Controls.Add(this.fullBakPath_chb);
            this.BackupsTab.Controls.Add(this.restoreSelectedBtn);
            this.BackupsTab.Controls.Add(this.delAllBaksBtn);
            this.BackupsTab.Controls.Add(this.makeBakBtn);
            this.BackupsTab.Controls.Add(this.restoreAllBaksBtn);
            this.BackupsTab.Controls.Add(this.delSelectedBak);
            this.BackupsTab.Controls.Add(this.bakLabel2);
            this.BackupsTab.Controls.Add(this.bakLabel1);
            this.BackupsTab.Controls.Add(this.bakListPanel);
            this.BackupsTab.Location = new System.Drawing.Point(0, 19);
            this.BackupsTab.Name = "BackupsTab";
            this.BackupsTab.Padding = new System.Windows.Forms.Padding(3);
            this.BackupsTab.Size = new System.Drawing.Size(577, 383);
            this.BackupsTab.TabIndex = 3;
            this.BackupsTab.Text = "Backups";
            // 
            // fullBakPath_chb
            // 
            this.fullBakPath_chb.AutoSize = true;
            this.fullBakPath_chb.Location = new System.Drawing.Point(421, 121);
            this.fullBakPath_chb.Name = "fullBakPath_chb";
            this.fullBakPath_chb.Size = new System.Drawing.Size(93, 17);
            this.fullBakPath_chb.TabIndex = 17;
            this.fullBakPath_chb.Text = "Show full path";
            this.fullBakPath_chb.UseVisualStyleBackColor = true;
            // 
            // restoreSelectedBtn
            // 
            this.restoreSelectedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.restoreSelectedBtn.Location = new System.Drawing.Point(421, 185);
            this.restoreSelectedBtn.Name = "restoreSelectedBtn";
            this.restoreSelectedBtn.Size = new System.Drawing.Size(135, 35);
            this.restoreSelectedBtn.TabIndex = 16;
            this.restoreSelectedBtn.Text = "Restore Selected";
            this.restoreSelectedBtn.UseVisualStyleBackColor = true;
            // 
            // delAllBaksBtn
            // 
            this.delAllBaksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.delAllBaksBtn.ForeColor = System.Drawing.Color.Red;
            this.delAllBaksBtn.Location = new System.Drawing.Point(421, 309);
            this.delAllBaksBtn.Name = "delAllBaksBtn";
            this.delAllBaksBtn.Size = new System.Drawing.Size(135, 35);
            this.delAllBaksBtn.TabIndex = 15;
            this.delAllBaksBtn.Text = "Delete All Backups";
            this.delAllBaksBtn.UseVisualStyleBackColor = true;
            // 
            // makeBakBtn
            // 
            this.makeBakBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.makeBakBtn.Location = new System.Drawing.Point(421, 144);
            this.makeBakBtn.Name = "makeBakBtn";
            this.makeBakBtn.Size = new System.Drawing.Size(135, 35);
            this.makeBakBtn.TabIndex = 14;
            this.makeBakBtn.Text = "New Backup";
            this.makeBakBtn.UseVisualStyleBackColor = true;
            // 
            // restoreAllBaksBtn
            // 
            this.restoreAllBaksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.restoreAllBaksBtn.Location = new System.Drawing.Point(421, 226);
            this.restoreAllBaksBtn.Name = "restoreAllBaksBtn";
            this.restoreAllBaksBtn.Size = new System.Drawing.Size(135, 36);
            this.restoreAllBaksBtn.TabIndex = 13;
            this.restoreAllBaksBtn.Text = "Restore All Files";
            this.restoreAllBaksBtn.UseVisualStyleBackColor = true;
            // 
            // delSelectedBak
            // 
            this.delSelectedBak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.delSelectedBak.ForeColor = System.Drawing.Color.Red;
            this.delSelectedBak.Location = new System.Drawing.Point(421, 268);
            this.delSelectedBak.Name = "delSelectedBak";
            this.delSelectedBak.Size = new System.Drawing.Size(135, 35);
            this.delSelectedBak.TabIndex = 12;
            this.delSelectedBak.Text = "Delete Selected";
            this.delSelectedBak.UseVisualStyleBackColor = true;
            // 
            // bakLabel2
            // 
            this.bakLabel2.AutoSize = true;
            this.bakLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.bakLabel2.Location = new System.Drawing.Point(80, 8);
            this.bakLabel2.Name = "bakLabel2";
            this.bakLabel2.Size = new System.Drawing.Size(67, 15);
            this.bakLabel2.TabIndex = 11;
            this.bakLabel2.Text = "Backup file";
            // 
            // bakLabel1
            // 
            this.bakLabel1.AutoSize = true;
            this.bakLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.bakLabel1.Location = new System.Drawing.Point(26, 8);
            this.bakLabel1.Name = "bakLabel1";
            this.bakLabel1.Size = new System.Drawing.Size(41, 15);
            this.bakLabel1.TabIndex = 10;
            this.bakLabel1.Text = "Select";
            // 
            // bakListPanel
            // 
            this.bakListPanel.AutoScroll = true;
            this.bakListPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bakListPanel.Location = new System.Drawing.Point(8, 34);
            this.bakListPanel.Name = "bakListPanel";
            this.bakListPanel.Size = new System.Drawing.Size(402, 322);
            this.bakListPanel.TabIndex = 9;
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(577, 443);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.betterPBar);
            this.Controls.Add(this.topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCC Mod Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.MyModsTab.ResumeLayout(false);
            this.MyModsTab.PerformLayout();
            this.CreateModpackTab.ResumeLayout(false);
            this.CreateModpackTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addRowButton)).EndInit();
            this.ConfigurationTab.ResumeLayout(false);
            this.ConfigurationTab.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BackupsTab.ResumeLayout(false);
            this.BackupsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel topBar;
        public System.Windows.Forms.PictureBox exitButton;
        public System.Windows.Forms.Label titleLabel;
        public System.Windows.Forms.PictureBox minButton;
        public System.Windows.Forms.PictureBox refreshButton;
        public System.Windows.Forms.Label version_lbl;
        public System.Windows.Forms.Panel betterPBar;
        //public System.Windows.Forms.TabControl TabControl;
        public ModManagerCustomControls.CustomTabControl TabControl;
        public System.Windows.Forms.TabPage MyModsTab;
        public System.Windows.Forms.TabPage CreateModpackTab;
        public System.Windows.Forms.TabPage ConfigurationTab;
        public System.Windows.Forms.CheckBox manualOverride;
        public System.Windows.Forms.CheckBox selectEnabled_chb;
        public System.Windows.Forms.Label homeEnabledLabel;
        public System.Windows.Forms.Button delModpack;
        public System.Windows.Forms.Button patchButton;
        public System.Windows.Forms.Label homeNameLabel;
        public System.Windows.Forms.Label homeSelectLabel;
        public System.Windows.Forms.Panel modListPanel;
        public System.Windows.Forms.Button resetApp;
        public System.Windows.Forms.CheckBox delOldBaks_chb;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox cfgTextBox3;
        public System.Windows.Forms.Button cfgBrowseBtn3;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox cfgTextBox2;
        public System.Windows.Forms.Button cfgBrowseBtn2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox cfgTextBox1;
        public System.Windows.Forms.Button cfgBrowseBtn1;
        public System.Windows.Forms.Label configLabel3;
        public System.Windows.Forms.Label configLabel2;
        public System.Windows.Forms.Button cfgUpdateBtn;
        public System.Windows.Forms.Label configLabel1;
        public System.Windows.Forms.TabPage BackupsTab;
        public System.Windows.Forms.CheckBox fullBakPath_chb;
        public System.Windows.Forms.Button restoreSelectedBtn;
        public System.Windows.Forms.Button delAllBaksBtn;
        public System.Windows.Forms.Button makeBakBtn;
        public System.Windows.Forms.Button restoreAllBaksBtn;
        public System.Windows.Forms.Button delSelectedBak;
        public System.Windows.Forms.Label bakLabel2;
        public System.Windows.Forms.Label bakLabel1;
        public System.Windows.Forms.Panel bakListPanel;
        public System.Windows.Forms.Label modpackName_label;
        public System.Windows.Forms.TextBox modpackName_txt;
        public System.Windows.Forms.Button clearBtn;
        public System.Windows.Forms.PictureBox addRowButton;
        public System.Windows.Forms.Button createModpackBtn;
        public System.Windows.Forms.Label createLabel2;
        public System.Windows.Forms.Label createLabel1;
        public System.Windows.Forms.Panel createFilesPanel;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label CreatedByLabel;
    }
}

