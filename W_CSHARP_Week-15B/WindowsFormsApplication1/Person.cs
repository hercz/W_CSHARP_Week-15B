using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    /// <summary>
    /// Person class, which contains names, addresses, phone numbers, date of data
    /// recoding and a serial number of persons. The class is serializable. ...
    /// </summary>

    [Serializable]
    public class Person : IDeserializationCallback
    {
        #region properties 
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        private int _phone;

        public int Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private DateTime _recordedDate;

        public DateTime RecordedDate
        {
            get { return _recordedDate; }
            set { _recordedDate = value; }
        }

        [NonSerialized] private int _serialNumber = 1;

        public int SerialNumber
        {
            get
            {
                return _serialNumber;
            }
            set { _serialNumber = value; }
        }
        #endregion properties 

        public void SetFileName()
        {
            while (File.Exists($"persons\\person{ SerialNumber.ToString("00")}.dat"))
            {
                SerialNumber++;
            }
            //if (SerialNumber >99)
            //    throw Exception
        }

        public void Serialize(Person person)
        {
            //SetFileName();
            RecordedDate = DateTime.Now;
            using (Stream stream = new FileStream($"persons\\person{SerialNumber.ToString("00")}.dat", FileMode.Create))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Person));
                xml.Serialize(stream, person);
            }
        }

        public void OnDeserialization(object sender)
        {
            while (File.Exists($"persons\\person{ SerialNumber.ToString("00")}.dat"))
            {
                SerialNumber++;
            };

        }
    }
}
