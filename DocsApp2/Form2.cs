using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocsApp2
{
    public partial class Form2 : Form
    {
        public static int Brunch, Till;
        public static string Address, FIO;

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            labelData.Text = labelData.Text + localDate.ToString("MM/dd/yyyy HH:mm:ss");
        }

        public Form2(int Brunch_p, string Addres_p, int Till_p, string FIO_p)
        {
            InitializeComponent();
            Brunch = Brunch_p;
            Address = Addres_p;
            Till = Till_p;
            FIO = FIO_p;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Создаём объект класса data
            DataSet ds = new DataSet();

            //++++++++++Таблица с чеками++++++++++
            DataTable chek = new DataTable("Чеки");

            ds.Tables.Add(chek);

            DataColumn dc = new DataColumn("НомерЧека",
            Type.GetType("System.Int32"));
            ds.Tables["Чеки"].Columns.Add(dc);

            dc = new DataColumn("ДатаЧека", Type.GetType("System.DateTime"));
            ds.Tables["Чеки"].Columns.Add(dc);

            dc = new DataColumn("НомерКассы", Type.GetType("System.String"));
            ds.Tables["Чеки"].Columns.Add(dc);

            dc = new DataColumn("Филиал", Type.GetType("System.String"));
            ds.Tables["Чеки"].Columns.Add(dc);

            dc = new DataColumn("ФИОКассира", Type.GetType("System.String"));
            ds.Tables["Чеки"].Columns.Add(dc);

            dc = new DataColumn("Адрес", Type.GetType("System.String"));
            ds.Tables["Чеки"].Columns.Add(dc);

            dc = new DataColumn("ДисконтнаяКарта", Type.GetType("System.Int32"));
            ds.Tables["Чеки"].Columns.Add(dc);

            dc = new DataColumn("ОбщаяСтоимость",
            Type.GetType("System.Int32"));
            ds.Tables["Чеки"].Columns.Add(dc);

            //Создём ключи
            DataColumn[] key = new DataColumn[2]
            { ds.Tables["Чеки"].Columns["НомерЧека"],
              ds.Tables["Чеки"].Columns["ДатаЧека"] };
            ds.Tables["Чеки"].PrimaryKey = key;
            //----------Таблица с чеками----------

            //+++++Таблица с позициями в чеке+++++
            ds.Tables.Add(new DataTable("ЗаписьЧека"));

            dc = new DataColumn("НомерЗаписиЧека",
            Type.GetType("System.Int32"));
            ds.Tables["ЗаписьЧека"].Columns.Add(dc);

            dc = new DataColumn("НомерЧека", Type.GetType("System.Int32"));
            ds.Tables["ЗаписьЧека"].Columns.Add(dc);

            dc = new DataColumn("ДатаЧека", Type.GetType("System.DateTime"));
            ds.Tables["ЗаписьЧека"].Columns.Add(dc);

            dc = new DataColumn("Товар", Type.GetType("System.String"));
            ds.Tables["ЗаписьЧека"].Columns.Add(dc);

            dc = new DataColumn("ЦенаТовара", Type.GetType("System.Int32"));
            ds.Tables["ЗаписьЧека"].Columns.Add(dc);

            dc = new DataColumn("Количество", Type.GetType("System.Int32"));
            ds.Tables["ЗаписьЧека"].Columns.Add(dc);

            dc = new DataColumn("Стоимость", Type.GetType("System.Int32"));
            ds.Tables["ЗаписьЧека"].Columns.Add(dc);

            //Создём ключи
            key = new DataColumn[3]
            { ds.Tables["ЗаписьЧека"].Columns["НомерЗаписиЧека"],
              ds.Tables["ЗаписьЧека"].Columns["НомерЧека"],
              ds.Tables["ЗаписьЧека"].Columns["ДатаЧека"] };
            ds.Tables["ЗаписьЧека"].PrimaryKey = key;
            //-----Таблица с позициями в чеке-----


            //++++Таблица с дисконтными картами+++
            ds.Tables.Add(new DataTable("ДисконтнаяКарта"));

            dc = new DataColumn("ДисконтнаяКарта",
           Type.GetType("System.Int32"));
            ds.Tables["ДисконтнаяКарта"].Columns.Add(dc);

            dc = new DataColumn("ФИО", Type.GetType("System.String"));
            ds.Tables["ДисконтнаяКарта"].Columns.Add(dc);

            dc = new DataColumn("РазмерСкидки", Type.GetType("System.Int32"));
            ds.Tables["ДисконтнаяКарта"].Columns.Add(dc);

            dc = new DataColumn("НомерКарты", Type.GetType("System.Int32"));
            ds.Tables["ДисконтнаяКарта"].Columns.Add(dc);

            //Создём ключи
            key = new DataColumn[1]
            { ds.Tables["ДисконтнаяКарта"].Columns["НомерКарты"] };
            ds.Tables["ДисконтнаяКарта"].PrimaryKey = key;
            //----Таблица с дисконтными картами---

            //++++++++++Связи++++++++++
            DataRelation rel = new DataRelation("СвязьЧека",
            new DataColumn[]{ds.Tables["Чеки"].Columns["НомерЧека"],
                             ds.Tables["Чеки"].Columns["ДатаЧека"]},
            new DataColumn[]{ds.Tables["ЗаписьЧека"].Columns["НомерЧека"],
                             ds.Tables["ЗаписьЧека"].Columns["ДатаЧека"]});

            DataRelation rel1 = new DataRelation("СвязьКарты",
            new DataColumn[] { ds.Tables["Чеки"].Columns["ДисконтнаяКарта"] },
            new DataColumn[] { ds.Tables["ДисконтнаяКарта"].Columns["НомерКарты"] });
            ds.Relations.Add(rel);
            ds.Relations.Add(rel1);
            //----------Связи----------

            //Экспорт  таблицы
            //ds.WriteXml("chek.xml", XmlWriteMode.WriteSchema);

            //+++++++++++Установка инфы++++++++++
            labelBrunch.Text = labelBrunch.Text + Brunch.ToString();
            labelTill.Text = labelTill.Text + Till.ToString();
            labelFIO.Text = labelFIO.Text + FIO;
            //----------Установка инфы----------
        }
    }
}
