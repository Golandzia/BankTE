using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.IO;


namespace FilesWPF
{
    public class FileWorker
    {
        public ObservableCollection<User> Filework()
        {
            var userList = new ObservableCollection<User>();
            using (StreamReader reader = new StreamReader(@"D:\BankTE\BankTE\Model.txt"))
            {
                foreach(var item in reader.ReadToEnd().Split('\n'))
                {
                    var arrayString = item.Split(';');
                    if (arrayString[0] != "FirstName")
                    {
                        var user = new User()
                        {
                            FirstName = arrayString[0],
                            MiddleName = arrayString[1],
                            Lastame = arrayString[2],
                            NumberPhone = arrayString[3],
                            Role = arrayString[4],
                            Password = arrayString[5],
                            NubmerCard = arrayString[6],
                        };
                        userList.Add(user);
                    }
                }
                return userList;
            }
        }
    }
}
