namespace WinFormsChapter5Demo;

partial class MainForm
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
        mainListBox = new ListBox();
        loadButton = new Button();
        overwriteButton = new Button();
        pickFileCheckBox = new CheckBox();
        mainListLabel = new Label();
        mainOpenFileDialog = new OpenFileDialog();
        mainSaveFileDialog = new SaveFileDialog();
        saveButton = new Button();
        appendCheckBox = new CheckBox();
        SuspendLayout();
        // 
        // mainListBox
        // 
        mainListBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        mainListBox.FormattingEnabled = true;
        mainListBox.ItemHeight = 31;
        mainListBox.Location = new Point(12, 32);
        mainListBox.Name = "mainListBox";
        mainListBox.Size = new Size(590, 407);
        mainListBox.TabIndex = 1;
        // 
        // loadButton
        // 
        loadButton.Location = new Point(617, 32);
        loadButton.Name = "loadButton";
        loadButton.Size = new Size(171, 29);
        loadButton.TabIndex = 2;
        loadButton.Text = "&Load from File";
        loadButton.UseVisualStyleBackColor = true;
        loadButton.Click += loadButton_Click;
        // 
        // overwriteButton
        // 
        overwriteButton.Location = new Point(0, 0);
        overwriteButton.Name = "overwriteButton";
        overwriteButton.Size = new Size(75, 23);
        overwriteButton.TabIndex = 7;
        // 
        // pickFileCheckBox
        // 
        pickFileCheckBox.AutoSize = true;
        pickFileCheckBox.Location = new Point(617, 169);
        pickFileCheckBox.Name = "pickFileCheckBox";
        pickFileCheckBox.Size = new Size(84, 24);
        pickFileCheckBox.TabIndex = 5;
        pickFileCheckBox.Text = "&Pick File";
        pickFileCheckBox.UseVisualStyleBackColor = true;
        // 
        // mainListLabel
        // 
        mainListLabel.AutoSize = true;
        mainListLabel.Location = new Point(12, 9);
        mainListLabel.Name = "mainListLabel";
        mainListLabel.Size = new Size(97, 20);
        mainListLabel.TabIndex = 0;
        mainListLabel.Text = "&Main List Box";
        // 
        // saveButton
        // 
        saveButton.Location = new Point(617, 77);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(171, 29);
        saveButton.TabIndex = 3;
        saveButton.Text = "&Save to File";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += saveButton_Click;
        // 
        // appendCheckBox
        // 
        appendCheckBox.AutoSize = true;
        appendCheckBox.Location = new Point(617, 126);
        appendCheckBox.Name = "appendCheckBox";
        appendCheckBox.Size = new Size(129, 24);
        appendCheckBox.TabIndex = 4;
        appendCheckBox.Text = "&Append to File";
        appendCheckBox.UseVisualStyleBackColor = true;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(appendCheckBox);
        Controls.Add(saveButton);
        Controls.Add(mainListLabel);
        Controls.Add(pickFileCheckBox);
        Controls.Add(overwriteButton);
        Controls.Add(loadButton);
        Controls.Add(mainListBox);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "MainForm";
        Text = "Chapter 5 Demo";
        Load += MainForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListBox mainListBox;
    private Button loadButton;
    private Button overwriteButton;
    private CheckBox pickFileCheckBox;
    private Label mainListLabel;
    private OpenFileDialog mainOpenFileDialog;
    private SaveFileDialog mainSaveFileDialog;
    private Button saveButton;
    private CheckBox appendCheckBox;
}
