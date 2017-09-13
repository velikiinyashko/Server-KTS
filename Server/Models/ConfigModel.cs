using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Models
{
    public class AuthForm
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    //[Table("Configuration")]
    //public class ServerConf : INotifyPropertyChanged
    //{

    //    private string version;
    //    private string address;
    //    private int port;
    //    private string addressbase;
    //    private int portbase;
    //    private string userbase;
    //    private string passwdbase;
    //    private string namebase;

    //    [Key, Column("Id")]
    //    public int ServerConfId { get; set; }
    //    [Column("Version")]
    //    public string Version
    //    {
    //        get { return version; }
    //        set
    //        {
    //            version = value;
    //            OnPropertyChanged("Version");
    //        }
    //    }
    //    [Column("Address")]
    //    public string Address
    //    {
    //        get { return address; }
    //        set
    //        {
    //            address = value;
    //            OnPropertyChanged("Address");
    //        }
    //    }
    //    [Column("Port")]
    //    public int Port
    //    {
    //        get { return port; }
    //        set
    //        {
    //            port = value;
    //            OnPropertyChanged("Port");
    //        }
    //    }
    //    [Column("AddressBase")]
    //    public string AddressBase
    //    {
    //        get { return addressbase; }
    //        set
    //        {
    //            addressbase = value;
    //            OnPropertyChanged("AddressBase");
    //        }
    //    }
    //    [Column("PortBase")]
    //    public int PortBase
    //    {
    //        get { return portbase; }
    //        set
    //        {
    //            portbase = value;
    //            OnPropertyChanged("PortBase");
    //        }
    //    }
    //    [Column("UserBase")]
    //    public string UserBase
    //    {
    //        get { return userbase; }
    //        set
    //        {
    //            userbase = value;
    //            OnPropertyChanged("UserBase");
    //        }
    //    }
    //    [Column("PasswdBase")]
    //    public string PasswdBase
    //    {
    //        get { return passwdbase; }
    //        set
    //        {
    //            passwdbase = value;
    //            OnPropertyChanged("PasswdBase");
    //        }
    //    }
    //    [Column("NameBase")]
    //    public string NameBase
    //    {
    //        get { return namebase; }
    //        set
    //        {
    //            namebase = value;
    //            OnPropertyChanged("NameBase");
    //        }
    //    }

    //    public event PropertyChangedEventHandler PropertyChanged;
    //    public void OnPropertyChanged([CallerMemberName]string prop = "")
    //    {
    //        if (PropertyChanged != null)
    //        {
    //            PropertyChanged(this, new PropertyChangedEventArgs(prop));
    //        }
    //    }
    //}

    [Table("Conf")]
    public class ApplicationConfig
    {
        public int AppConfigId { get; set; }
        public int IdConfig { get; set; }
        public string ConfigName { get; set; }
        public string ConfigValue { get; set; }
    }
}