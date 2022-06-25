using System.Linq;
class User
{
    public string userName;
    public int cardID;
    int password;
    public int Password
    {
        get { return password; }
        set { password = value; }
    }

    int surplus;
    public int Surplus
    {
        get { return surplus; }
        set { surplus = value; }
    }
    public User(string userName, int cardID, int password, int surplus)
    {
        this.userName=userName;
        this.cardID=cardID;
        this.password=password;
        this.surplus=surplus;
    }
    

}
class Atm
{

    static void displayMenu()
    {
        Console.WriteLine("Ban co the nhap lua chon sau:\n");
        Console.WriteLine("1.Rut tien");
        Console.WriteLine("2.Chuyen tien");
        Console.WriteLine("3.Kiem tra so du");
        Console.WriteLine("4.Phim khac de thoat");
    }
    static void Main(string[] args)
    {
        User user1 = new User("Vu Viet Quy", 123, 456, 3000);
        User user2 = new User("Ta Duy Linh", 124, 456, 30000);
        List<User> mbBank = new List<User>();
        mbBank.Add(user1);
        mbBank.Add(user2);



        int userName, password;
        int count = 0,ch, surplus=3000,num;
        int isContinue=1;


        Console.WriteLine("Chao ban den voi MB bank");
        do
        {
            Console.WriteLine("Moi ban nhap tai khoan:");
            userName = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Moi ban nhap mat khau");
            password = Convert.ToInt32(Console.ReadLine());
            var curentUser = mbBank.Where(
                user => user.cardID == userName && user.Password == password
            );    
           if (curentUser.Count()==1)
            {
                User user = curentUser.First();
                Console.WriteLine("Chao {0}",user.userName);
                do
                {
                    displayMenu();
                    ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            Console.WriteLine("Moi ban nhap so tien");
                            num = Convert.ToInt32(Console.ReadLine());
                            if (num>user.Surplus)
                            {
                                Console.WriteLine("So tien muon chuyen vuot qua so du");
                            }
                            else if(num<300 && num%5==0)
                            {
                                Console.WriteLine("Rut tien thanh cong");
                                user.Surplus-=num;
                                Console.WriteLine("So du hien tai:{0}", user.Surplus);
                            }
                            else
                            {
                                Console.WriteLine("So tien phai nho hon 300 hoac la boi cua 5");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Nhap so tai khoan can chuyen");
                            num = Convert.ToInt32(Console.ReadLine());
                            var targetUser = mbBank.Where(
                                user => user.cardID == num
                            );
                            if (targetUser.Count()>0)
                            {
                                User target = targetUser.First();
                                Console.WriteLine("Tai khoan dich {0}",target.userName);
                                Console.WriteLine("Nhap so tien can chuyen:");
                                num = Convert.ToInt32(Console.ReadLine());
                                if (num>user.Surplus)
                                {
                                    Console.WriteLine("So tien muon chuyen vuot qua so du");
                                }
                                else if (num<300 && num%5==0)
                                {
                                    Console.WriteLine("Chuyen tien thanh cong");
                                    user.Surplus-=num;
                                    target.Surplus =  target.Surplus + num;
                                    Console.WriteLine("So du hien tai:{0}", user.Surplus);
                                }
                                else
                                {
                                    Console.WriteLine("So tien phai nho hon 300 hoac la boi cua 5");
                                }

                            }
                            else
                            {
                                Console.WriteLine("So tai khoan khong hop le");
                            }
                            break;
                        case 3:
                            Console.WriteLine("So du cua ban la: {0}",user.Surplus);
                            break;
                        default:
                            Console.WriteLine("Ban da nhap sai lua chon");
                            break;
                    }
                    Console.WriteLine("Ban co muon tiep tuc khong?[0/1]");
                    isContinue = Convert.ToInt32(Console.ReadLine());
                    if(isContinue == 0)
                    {
                        Console.WriteLine("Chao va hen gap lai");
                        break;
                    }
                } while (true);
                

            }
            else
            {
                Console.WriteLine("Ban da nhap sai tk hoac mk.Vui long thu lai");
                count++;
            }
        } while (count<=3 );
    }
}