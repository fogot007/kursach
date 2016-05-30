using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace kursach
{
    class Xml
    {
        public void SaveFavorites(DataSet dataSet)
        {
            dataSet.Tables[0]?.WriteXml(
                @"C:\Users\skalamf\Documents\Visual Studio 2015\Projects\kursach\kursach\Favorites.xml");
        }

        public void FillDataFavorites(DataSet dataSet, DataGridView dataGridView)
        {
            try
            {
                var xmlFile =
                    XmlReader.Create(
                        @"C:\Users\skalamf\Documents\Visual Studio 2015\Projects\kursach\kursach\Favorites.xml",
                        new XmlReaderSettings());
                dataSet.ReadXml(xmlFile);
                dataGridView.DataSource = dataSet.Tables[0];
                if (dataSet.Tables[0].Rows[0][0].ToString() == "")
                    dataSet.Clear();
                xmlFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SaveDataBaseUsers(DataTable dataTable)
        {
            dataTable.WriteXml(
                @"C:\Users\skalamf\Documents\Visual Studio 2015\Projects\kursach\kursach\DataBaseUsers.xml");
        }

        public void SaveDataBaseShops(DataTable dataTable)
        {
            dataTable.WriteXml(
                @"C:\Users\skalamf\Documents\Visual Studio 2015\Projects\kursach\kursach\DataBaseShops.xml");
        }

        public DataSet FillUsersFromExport()
        {
            var dataSet = new DataSet();
            try
            {
                var xmlFile =
                    XmlReader.Create(
                        @"C:\Users\skalamf\Documents\Visual Studio 2015\Projects\kursach\kursach\DataBaseUsers.xml",
                        new XmlReaderSettings());
                dataSet.ReadXml(xmlFile);
                xmlFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dataSet;
        }

        public DataSet FillShopsFromExport()
        {
            var dataSet = new DataSet();
            try
            {
                var xmlFile =
                    XmlReader.Create(
                        @"C:\Users\skalamf\Documents\Visual Studio 2015\Projects\kursach\kursach\DataBaseShops.xml",
                        new XmlReaderSettings());
                dataSet.ReadXml(xmlFile);
                xmlFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dataSet;
        }
    }
}