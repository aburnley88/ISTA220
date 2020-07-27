using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WhileStatement
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void openFileClick(object sender, RoutedEventArgs e)
        {
            FileOpenPicker fp = new FileOpenPicker();
            fp.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            fp.ViewMode = PickerViewMode.List;
            fp.FileTypeFilter.Add("*");

            StorageFile file = await fp.PickSingleFileAsync();
            if (file != null)
            {
                fileName.Text = file.Path;

                var fileStream = await file.OpenAsync(FileAccessMode.Read);
                var inputStream = fileStream.GetInputStreamAt(0);
                //TextReader is a class provided by the Microsoft.Net framework that you can use
                //for reading streams of characters from sources such as files
                //It is located it in the System.IO namespace
                TextReader reader = new StreamReader(inputStream.AsStreamForRead());
                displayData(reader);
            }
        }

        private void displayData(TextReader reader)
        {
            
            //The source variable refers to the large text box on the form
            //setting its Text property to ("") clears any text that is currently displayed 
            //in this text box.
            source.Text = "";

            //declares a string variable called line and calls the reader.ReadLine method to read the 
            //finrst line from the file into this variable. 
            //This method returns either the next line of text from the file
            //or a special value called null when there are no more lines to read.
            string line = reader.ReadLine();

            //while loop that iterates through the file one line a t a time until there are no more
            //lines available. 
            while(line != null)
            {
                source.Text += line + '\n';
                line = reader.ReadLine();
            }
            reader.Dispose();

        }
    }
}
