using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public static class ShopDB
    {
        public static Warehouse[] warehouses = new Warehouse[5];
        public static User[] users = new User[50];
        public static Grade[] grades = new Grade[20];
        public static Warehouse warehouse { get; set; }
        public static void Initialize()
        {
            createGrade();
            User administrator = new User();
            administrator.Name = "Elshad";
            administrator.Password = "elshad";
            administrator.Role = Role.Administrator;
            users[0] = administrator;
            /*--------------------------------------*/
            Warehouse shop1 = new Warehouse();
            shop1.Name = "NewYorker";
            shop1.Adress = "28 Mol";
            shop1.Grade = grades[4];

            User menecerNY = new User();
            menecerNY.Name = "Mikayil";
            menecerNY.Password = "mikayil";
            menecerNY.Role = Role.Menecer;
            shop1.users[0] = menecerNY;
            users[1] = menecerNY;

            User satici1 = new User();
            satici1.Name = "Senan";
            satici1.Role = Role.Satici;
            shop1.users[1] = satici1;
            users[2] = satici1;

            User satici2 = new User();
            satici2.Name = "Orxan";
            satici2.Role = Role.Satici;
            shop1.users[2] = satici2;
            users[3] = satici2;

            User satici3 = new User();
            satici3.Name = "Xeyal";
            satici3.Role = Role.Satici;
            shop1.users[3] = satici3;
            users[4] = satici3;

            User satici4 = new User();
            satici4.Name = "Aysen";
            satici4.Role = Role.Satici;
            shop1.users[4] = satici4;
            users[21] = satici4;

            warehouses[0] = shop1;
            /*--------------------------------------*/
            Warehouse shop2 = new Warehouse();
            shop2.Name = "LCW";
            shop2.Adress = "28 Mol";
            shop2.Grade = grades[1];

            User menecerLCW = new User();
            menecerLCW.Name = "Nofel";
            menecerLCW.Password = "nofel";
            menecerLCW.Role = Role.Menecer;
            shop2.users[0] = menecerLCW;
            users[5] = menecerLCW;

            User satici11 = new User();
            satici11.Name = "Ceyhun";
            satici11.Surname = "Zeynalli";
            satici11.Role = Role.Satici;
            shop2.users[1] = satici11;
            users[6] = satici11;

            User satici22 = new User();
            satici22.Name = "Cosqun";
            satici22.Surname = "Zeynalli";
            satici22.Role = Role.Satici;
            shop2.users[2] = satici22;
            users[7] = satici22;

            User satici33 = new User();
            satici33.Name = "Musa";
            satici33.Role = Role.Satici;
            shop2.users[3] = satici33;
            users[8] = satici33;

            warehouses[1] = shop2;

            /*--------------------------------------*/
            Warehouse shop3 = new Warehouse();
            shop3.Name = "ZARA";
            shop3.Adress = "28 Mol";
            shop3.Grade = grades[2];

            User menecerZARA = new User();
            menecerZARA.Name = "Aysad";
            menecerZARA.Password = "aysad";
            menecerZARA.Role = Role.Menecer;
            shop3.users[0] = menecerZARA;
            users[9] = menecerZARA;

            User satici111 = new User();
            satici111.Name = "Seymur";
            satici111.Role = Role.Satici;
            shop3.users[1] = satici111;
            users[10] = satici111;

            User satici222 = new User();
            satici222.Name = "Esger";
            satici222.Role = Role.Satici;
            shop3.users[2] = satici222;
            users[11] = satici222;

            User satici333 = new User();
            satici333.Name = "Samir";
            satici333.Role = Role.Satici;
            shop3.users[3] = satici333;
            users[12] = satici333;

            warehouses[2] = shop3;

            /*--------------------------------------*/
            Warehouse shop4 = new Warehouse();
            shop4.Name = "MANGO";
            shop4.Adress = "28 Mol";
            shop4.Grade = grades[3];

            User menecerMANGO = new User();
            menecerMANGO.Name = "Xezer";
            menecerMANGO.Password = "xezer";
            menecerMANGO.Role = Role.Menecer;
            shop4.users[0] = menecerMANGO;
            users[13] = menecerMANGO;

            User satici1111 = new User();
            satici1111.Name = "Ayxan";
            satici1111.Role = Role.Satici;
            shop4.users[1] = satici1111;
            users[14] = satici1111;

            User satici2222 = new User();
            satici2222.Name = "Nicat";
            satici2222.Role = Role.Satici;
            shop4.users[2] = satici2222;
            users[15] = satici2222;

            User satici3333 = new User();
            satici3333.Name = "Shikar";
            satici3333.Role = Role.Satici;
            shop4.users[3] = satici3333;
            users[16] = satici3333;

            warehouses[3] = shop4;

            /*--------------------------------------*/
            Warehouse shop5 = new Warehouse();
            shop5.Name = "WESTLA";
            shop5.Adress = "28 Mol";
            shop5.Grade = grades[4];

            User menecerWESTLA = new User();
            menecerWESTLA.Name = "Emrah";
            menecerWESTLA.Password = "emrah";
            menecerWESTLA.Role = Role.Menecer; 
            shop5.users[0] = menecerWESTLA;
            users[17] = menecerWESTLA;

            User satici11111 = new User();
            satici11111.Name = "Tale";
            satici11111.Role = Role.Satici;
            shop5.users[1] = satici11111;
            users[18] = satici11111;

            User satici22222 = new User();
            satici22222.Name = "Aga";
            satici22222.Role = Role.Satici;
            shop5.users[2] = satici22222;
            users[19] = satici22222;

            User satici33333 = new User();
            satici33333.Name = "Ferid";
            satici33333.Role = Role.Satici;
            shop5.users[3] = satici33333;
            users[20] = satici33333;

            warehouses[4] = shop5;

            /*--------------------------------------*/
            addMaash();
        }
        public static void addMaash()
        {
            foreach (User user in users)
            {
                if (user != null)
                {
                    if (user.Role == Role.Satici)
                    {
                        user.Salary = 500;
                    }
                    if (user.Role == Role.Menecer)
                    {
                        user.Salary = 1000;
                    }
                    if (user.Role == Role.Administrator)
                    {
                        user.Salary = 5000;
                    }
                }
            }
            
        }
        public static void createGrade()
        {

            //100000 satilibsa 100 manat
            Grade grade1 = new Grade();
            grade1.Name = "G01";
            grade1.perOrMan = percentOrManat.Manat;
            grades[0] = grade1;

            //340000 satilibsa 1% manat
            Grade grade2 = new Grade();
            grade2.Name = "G02";
            grade2.perOrMan = percentOrManat.Percent;
            grades[1] = grade2;


            //340000 satilibsa 500 manat
            Grade grade3 = new Grade();
            grade3.Name = "G02M";
            grade3.perOrMan = percentOrManat.Manat;
            grades[2] = grade3;

            //20000 satilibsa 200 manat
            Grade grade4 = new Grade();
            grade4.Name = "G02NS";
            grade4.perOrMan = percentOrManat.Manat;
            grades[3] = grade4;

            //2000000 satilibsa 5% manat
            Grade grade5 = new Grade();
            grade5.Name = "G03M";
            grade5.perOrMan = percentOrManat.Percent;
            grades[4] = grade5;

            //200000-300000 satilibsa 3% manat, 3000000-4000000 satilibsa 5% manat,
            //5000000 satilibsa 7% manat
            Grade grade6 = new Grade();
            grade6.Name = "G04M";
            grade6.perOrMan = percentOrManat.Percent;
            grades[5] = grade6;
        }
    }
}
