﻿namespace GUI
{
    partial class fAddSkill
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
            this.cbSkillName = new Krypton.Toolkit.KryptonComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSkillDescription = new Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new Krypton.Toolkit.KryptonButton();
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            this.txtExpectedWage = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cbSkillName)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSkillName
            // 
            this.cbSkillName.DropButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.cbSkillName.DropDownWidth = 212;
            this.cbSkillName.IntegralHeight = false;
            this.cbSkillName.Location = new System.Drawing.Point(38, 92);
            this.cbSkillName.Name = "cbSkillName";
            this.cbSkillName.Size = new System.Drawing.Size(420, 40);
            this.cbSkillName.StateActive.ComboBox.Content.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.cbSkillName.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbSkillName.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbSkillName.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbSkillName.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbSkillName.StateCommon.ComboBox.Border.Rounding = 10F;
            this.cbSkillName.StateCommon.ComboBox.Border.Width = 2;
            this.cbSkillName.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(116)))), ((int)(((byte)(170)))));
            this.cbSkillName.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSkillName.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(3, 0, 0, 2);
            this.cbSkillName.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.cbSkillName.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.cbSkillName.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(116)))), ((int)(((byte)(170)))));
            this.cbSkillName.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(116)))), ((int)(((byte)(170)))));
            this.cbSkillName.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSkillName.StateNormal.ComboBox.Content.Padding = new System.Windows.Forms.Padding(-1, 3, -1, -1);
            this.cbSkillName.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbSkillName.StateTracking.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbSkillName.StateTracking.Item.Border.Color1 = System.Drawing.Color.Transparent;
            this.cbSkillName.StateTracking.Item.Border.Color2 = System.Drawing.Color.Transparent;
            this.cbSkillName.StateTracking.Item.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbSkillName.StateTracking.Item.Border.Width = 0;
            this.cbSkillName.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(116)))), ((int)(((byte)(170)))));
            this.cbSkillName.StateTracking.Item.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(116)))), ((int)(((byte)(170)))));
            this.cbSkillName.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSkillName.TabIndex = 0;
            this.cbSkillName.Text = "Choose your skill ...";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(116)))), ((int)(((byte)(170)))));
            this.lblTitle.Location = new System.Drawing.Point(96, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(303, 45);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "ADD NEW SKILL";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(116)))), ((int)(((byte)(170)))));
            this.label1.Location = new System.Drawing.Point(29, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Skill Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(116)))), ((int)(((byte)(170)))));
            this.label3.Location = new System.Drawing.Point(29, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Expected Wage";
            // 
            // txtSkillDescription
            // 
            this.txtSkillDescription.Location = new System.Drawing.Point(38, 269);
            this.txtSkillDescription.Multiline = true;
            this.txtSkillDescription.Name = "txtSkillDescription";
            this.txtSkillDescription.Size = new System.Drawing.Size(420, 103);
            this.txtSkillDescription.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtSkillDescription.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtSkillDescription.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSkillDescription.StateCommon.Border.Rounding = 10F;
            this.txtSkillDescription.StateCommon.Border.Width = 2;
            this.txtSkillDescription.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSkillDescription.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3, -1, 3, -1);
            this.txtSkillDescription.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(116)))), ((int)(((byte)(170)))));
            this.label6.Location = new System.Drawing.Point(29, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Description";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(275, 388);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnAdd.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnAdd.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnAdd.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnAdd.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.OverrideDefault.Border.Rounding = 10F;
            this.btnAdd.OverrideDefault.Border.Width = 1;
            this.btnAdd.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAdd.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAdd.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnAdd.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnAdd.OverrideFocus.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnAdd.OverrideFocus.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnAdd.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.OverrideFocus.Border.Rounding = 10F;
            this.btnAdd.OverrideFocus.Border.Width = 1;
            this.btnAdd.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAdd.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAdd.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Size = new System.Drawing.Size(90, 37);
            this.btnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnAdd.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnAdd.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnAdd.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnAdd.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateNormal.Border.Rounding = 10F;
            this.btnAdd.StateNormal.Border.Width = 1;
            this.btnAdd.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAdd.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAdd.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnAdd.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnAdd.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnAdd.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnAdd.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateTracking.Border.Rounding = 10F;
            this.btnAdd.StateTracking.Border.Width = 1;
            this.btnAdd.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAdd.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAdd.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Values.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(387, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnCancel.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnCancel.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnCancel.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnCancel.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.OverrideDefault.Border.Rounding = 10F;
            this.btnCancel.OverrideDefault.Border.Width = 1;
            this.btnCancel.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCancel.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCancel.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnCancel.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnCancel.OverrideFocus.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnCancel.OverrideFocus.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnCancel.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.OverrideFocus.Border.Rounding = 10F;
            this.btnCancel.OverrideFocus.Border.Width = 1;
            this.btnCancel.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCancel.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCancel.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Size = new System.Drawing.Size(90, 37);
            this.btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnCancel.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnCancel.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnCancel.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnCancel.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StateNormal.Border.Rounding = 10F;
            this.btnCancel.StateNormal.Border.Width = 1;
            this.btnCancel.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCancel.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCancel.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnCancel.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnCancel.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnCancel.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnCancel.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnCancel.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnCancel.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StateTracking.Border.Rounding = 10F;
            this.btnCancel.StateTracking.Border.Width = 1;
            this.btnCancel.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCancel.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCancel.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtExpectedWage
            // 
            this.txtExpectedWage.Location = new System.Drawing.Point(38, 180);
            this.txtExpectedWage.Multiline = true;
            this.txtExpectedWage.Name = "txtExpectedWage";
            this.txtExpectedWage.Size = new System.Drawing.Size(417, 38);
            this.txtExpectedWage.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtExpectedWage.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtExpectedWage.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpectedWage.StateCommon.Border.Rounding = 10F;
            this.txtExpectedWage.StateCommon.Border.Width = 2;
            this.txtExpectedWage.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpectedWage.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3, -1, 3, -1);
            this.txtExpectedWage.TabIndex = 15;
            // 
            // fAddSkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 439);
            this.CloseBox = false;
            this.Controls.Add(this.txtExpectedWage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSkillDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbSkillName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fAddSkill";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 15F;
            this.StateActive.Border.Width = 2;
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Width = 2;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.cbSkillName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonComboBox cbSkillName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Krypton.Toolkit.KryptonTextBox txtSkillDescription;
        private System.Windows.Forms.Label label6;
        private Krypton.Toolkit.KryptonButton btnAdd;
        private Krypton.Toolkit.KryptonButton btnCancel;
        private Krypton.Toolkit.KryptonTextBox txtExpectedWage;
    }
}