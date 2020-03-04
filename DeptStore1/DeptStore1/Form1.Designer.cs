namespace DeptStore1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "883095",
            "Babies",
            "Newborn Girl\'s Dress Set",
            "6 Months",
            "19.95",
            "12"}, 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "602936",
            "Teens",
            "Girls Classy Handbag",
            "One Size",
            "95.95",
            "4"}, 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "935709",
            "Women",
            "Cashmere Lined Glove\t",
            "8",
            "115.95",
            "12"}, 2);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "200759",
            "Men",
            "Trendy Jacket",
            "Medium",
            "45.85",
            "8"}, 3);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "735633",
            "Women",
            "Stretch Flare Jeans",
            "Petite",
            "27.75",
            "6"}, 2);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "492758",
            "Miscellaneous",
            "Chocolate Gift Box",
            "Medium",
            "45.00",
            "5"}, 4);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvwStoreItems = new System.Windows.Forms.ListView();
            this.colItemNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgLarge = new System.Windows.Forms.ImageList(this.components);
            this.imgSmall = new System.Windows.Forms.ImageList(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.RadioButton();
            this.btnList = new System.Windows.Forms.RadioButton();
            this.btnSmallIcons = new System.Windows.Forms.RadioButton();
            this.btnLargeIcons = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lvwStoreItems
            // 
            this.lvwStoreItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItemNumber,
            this.colCategory,
            this.colItemName,
            this.colItemSize,
            this.colUnitPrice,
            this.colQuantity});
            this.lvwStoreItems.HideSelection = false;
            this.lvwStoreItems.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.lvwStoreItems.LargeImageList = this.imgLarge;
            this.lvwStoreItems.Location = new System.Drawing.Point(13, 33);
            this.lvwStoreItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvwStoreItems.Name = "lvwStoreItems";
            this.lvwStoreItems.Size = new System.Drawing.Size(1041, 353);
            this.lvwStoreItems.SmallImageList = this.imgSmall;
            this.lvwStoreItems.TabIndex = 0;
            this.lvwStoreItems.UseCompatibleStateImageBehavior = false;
            this.lvwStoreItems.View = System.Windows.Forms.View.Details;
            // 
            // colItemNumber
            // 
            this.colItemNumber.Text = "Item #";
            this.colItemNumber.Width = 70;
            // 
            // colCategory
            // 
            this.colCategory.Text = "Category";
            this.colCategory.Width = 70;
            // 
            // colItemName
            // 
            this.colItemName.Text = "Item Name";
            this.colItemName.Width = 180;
            // 
            // colItemSize
            // 
            this.colItemSize.Text = "Size";
            this.colItemSize.Width = 80;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Text = "Unit Price";
            this.colUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colQuantity
            // 
            this.colQuantity.Text = "Qty";
            this.colQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colQuantity.Width = 40;
            // 
            // imgLarge
            // 
            this.imgLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLarge.ImageStream")));
            this.imgLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLarge.Images.SetKeyName(0, "Babies.ico");
            this.imgLarge.Images.SetKeyName(1, "Teens.ico");
            this.imgLarge.Images.SetKeyName(2, "Women.ico");
            this.imgLarge.Images.SetKeyName(3, "Men.ico");
            this.imgLarge.Images.SetKeyName(4, "Misc.ico");
            // 
            // imgSmall
            // 
            this.imgSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgSmall.ImageStream")));
            this.imgSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imgSmall.Images.SetKeyName(0, "Babies.ico");
            this.imgSmall.Images.SetKeyName(1, "Teens.ico");
            this.imgSmall.Images.SetKeyName(2, "Women.ico");
            this.imgSmall.Images.SetKeyName(3, "Men.ico");
            this.imgSmall.Images.SetKeyName(4, "Misc.ico");
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(867, 394);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 64);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Store Items";
            // 
            // btnDetails
            // 
            this.btnDetails.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnDetails.Checked = true;
            this.btnDetails.Image = global::DeptStore1.Properties.Resources.Details;
            this.btnDetails.Location = new System.Drawing.Point(664, 394);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(148, 64);
            this.btnDetails.TabIndex = 4;
            this.btnDetails.TabStop = true;
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.CheckedChanged += new System.EventHandler(this.btnDetails_CheckedChanged);
            // 
            // btnList
            // 
            this.btnList.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnList.Image = global::DeptStore1.Properties.Resources.List;
            this.btnList.Location = new System.Drawing.Point(464, 394);
            this.btnList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(148, 64);
            this.btnList.TabIndex = 3;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.CheckedChanged += new System.EventHandler(this.btnList_CheckedChanged);
            // 
            // btnSmallIcons
            // 
            this.btnSmallIcons.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnSmallIcons.Image = global::DeptStore1.Properties.Resources.LgIcon;
            this.btnSmallIcons.Location = new System.Drawing.Point(257, 394);
            this.btnSmallIcons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSmallIcons.Name = "btnSmallIcons";
            this.btnSmallIcons.Size = new System.Drawing.Size(148, 64);
            this.btnSmallIcons.TabIndex = 2;
            this.btnSmallIcons.UseVisualStyleBackColor = true;
            this.btnSmallIcons.CheckedChanged += new System.EventHandler(this.btnSmallIcons_CheckedChanged);
            // 
            // btnLargeIcons
            // 
            this.btnLargeIcons.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnLargeIcons.Image = global::DeptStore1.Properties.Resources.SmIcon;
            this.btnLargeIcons.Location = new System.Drawing.Point(60, 394);
            this.btnLargeIcons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLargeIcons.Name = "btnLargeIcons";
            this.btnLargeIcons.Size = new System.Drawing.Size(148, 64);
            this.btnLargeIcons.TabIndex = 1;
            this.btnLargeIcons.UseVisualStyleBackColor = true;
            this.btnLargeIcons.CheckedChanged += new System.EventHandler(this.btnLargeIcons_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnSmallIcons);
            this.Controls.Add(this.btnLargeIcons);
            this.Controls.Add(this.lvwStoreItems);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Department Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwStoreItems;
        private System.Windows.Forms.RadioButton btnLargeIcons;
        private System.Windows.Forms.RadioButton btnSmallIcons;
        private System.Windows.Forms.RadioButton btnList;
        private System.Windows.Forms.RadioButton btnDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imgLarge;
        private System.Windows.Forms.ImageList imgSmall;
        private System.Windows.Forms.ColumnHeader colItemNumber;
        private System.Windows.Forms.ColumnHeader colCategory;
        private System.Windows.Forms.ColumnHeader colItemName;
        private System.Windows.Forms.ColumnHeader colItemSize;
        private System.Windows.Forms.ColumnHeader colUnitPrice;
        private System.Windows.Forms.ColumnHeader colQuantity;
    }
}

