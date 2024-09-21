namespace WinFormsChapter5Demo;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    // *** note that MainForm is an exception to the way we usually name controls
    // *** this is because it is a class name and is not declared as a variable anywhere
    private void MainForm_Load(object sender, EventArgs e)
    {
        // load list from while loop
        int count = 0;
        while (true)
        {
            // this same as count = count + 1
            count++;

            if (count == 2)
                continue;

            mainListBox.Items.Add($"while loop {count}");

            if (count > 3)
                break;
        }

        // load list from do while loop
        count = 1;
        do
        {
            mainListBox.Items.Add($"do-while loop {count}");
            count++;
        } while (count <= 3);

        // load list from for loop
        for (int i = 0; i < 3; i++)
        {
            mainListBox.Items.Add($"for loop {count}");
        }

        // load list from for each loop
        string[] items = { "foreach loop 1", "foreach loop 2", "foreach loop 3" };
        foreach (string item in items)
        {
            mainListBox.Items.Add(item);
        }
    }

    private const string READ_FILE_PATH = "C:\\Users\\bray_\\source\\repos\\2024 fall c sharp class\\WinFormsChapter5Demo\\WinFormsChapter5Demo\\TextFiles\\ReadFromMe.txt";

    // verbatim string literal
    private const string WRITE_FILE_PATH = @"C:\Users\bray_\source\repos\2024 fall c sharp class\WinFormsChapter5Demo\WinFormsChapter5Demo\TextFiles\WriteToMe.txt";

    private const string INIT_PATH = @"C:\Users\bray_\source\repos\2024 fall c sharp class\WinFormsChapter5Demo\WinFormsChapter5Demo\TextFiles\";
    private void loadButton_Click(object sender, EventArgs e)
    {
        string filename = READ_FILE_PATH;

        if (pickFileCheckBox.Checked)
        {
            mainOpenFileDialog.InitialDirectory = INIT_PATH;
            if (mainOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = mainOpenFileDialog.FileName;
            }
        }

        // clear list box contents
        mainListBox.Items.Clear();

        // load the list from a file
        LoadListFromFile(filename);
        // this loads it a better way
        //LoadListFromFileWithUsing(filename);
    }

    private void LoadListFromFile(string filename)
    {
        try
        {
            // this is how it shows you to open a StreamReader in the book
            StreamReader reader = File.OpenText(filename);
            // these are all equivalent
            //StreamReader reader = new StreamReader(filename);
            //StreamReader reader = new(filename);

            // this is the same as string? line = "";
            // note we have declared this as nullable
            // because ReadLine can return null
            string? line = string.Empty;

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                if (!string.IsNullOrEmpty(line))
                {
                    mainListBox.Items.Add(line);
                }
            }

            // always close the file
            reader.Close();
        }
        catch (Exception ex)
        {
            // what happens if we get an exception before we close the file?
            MessageBox.Show(ex.Message);
        }
    }

    private void LoadListFromFileWithUsing(string filename)
    {
        try
        {
            // the using statement makes sure everything closed and cleaned up
            using (StreamReader reader = new(filename))
            {
                string? line = string.Empty;

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                    {
                        mainListBox.Items.Add(line);
                    }
                }

                // note we do not need to close the file
                // the using statement takes care of that for us
            }
        }
        catch (Exception ex)
        {
            // if we have an exception the using statement closes the file automatically
            MessageBox.Show(ex.Message);
        }
    }

    private void SaveListToFile(string filename, bool append)
    {

        try
        {
            StreamWriter writer;

            // these are the two ways the book shows to open a file to write to
            if (append)
            {
                // this will create a new file if none exists
                // if one does exist we will append to it
                writer = File.AppendText(filename);
            }
            else
            {
                // this creates a new file everytime overwriting any existing file
                writer = File.CreateText(filename);
            }

            // these are equivalent
            // but take whether or not to append as a parameter
            //writer = new StreamWriter(filename, append);
            //writer = new(filename, append);

            foreach (string item in mainListBox.Items)
            {
                writer.WriteLine(item);
            }

            // need to make sure close the file
            writer.Close();
        }
        catch (Exception ex)
        {
            // what happens if we get an exception before closing the file?
            MessageBox.Show(ex.Message);
        }
    }

    private void SaveListToFileWithUsing(string filename, bool append)
    {
        try
        {
            using (StreamWriter writer = new(filename, append))
            {
                foreach (string item in mainListBox.Items)
                {
                    writer.WriteLine(item);
                }

                // note we do not need to close file
                // because the using statement takes care of that
            }
        }
        catch (Exception ex)
        {
            // if we have an exception the using statement closes the file
            MessageBox.Show(ex.Message);
        }
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        string filename = WRITE_FILE_PATH;

        if (pickFileCheckBox.Checked)
        {
            mainSaveFileDialog.InitialDirectory = INIT_PATH;
            if (mainSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = mainSaveFileDialog.FileName;
            }
        }

        SaveListToFile(filename, appendCheckBox.Checked);
        // this saves it a better way
        //SaveListToFileWithUsing(filename, appendCheckBox.Checked);
    }
}

