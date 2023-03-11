using System;

namespace TopTune {
    class Peemmega {
        // Work01 จะบวกไหม
        static void Work01() {
            int summary = 0;

            for (int i = 1 ; i <= 3 ; i++) {
                Console.Write("Please input number"+i+": ");
                summary += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Summary is: "+ summary);
        }
       
        // Work02 เกินไปไหม
        static void Work02() {
            Console.Write("Please input minimum: ");
            float minimum = float.Parse(Console.ReadLine());
            Console.Write("Please input maximum: ");
            float maximum = float.Parse(Console.ReadLine());
            Console.Write("Please input number: ");
            float number = float.Parse(Console.ReadLine());

            if (number >= minimum && number <= maximum) {
                Console.WriteLine("True");   
            } else {
                Console.WriteLine("False");       
            }
        }
        
        // Work03 บิตโดนบิด
        static void Work03() {
            Console.Write("Please input number: ");
            int number = int.Parse(Console.ReadLine());
            
            int output = 1 << number;
            Console.WriteLine(output);
        }


        // Work04 ค่าสัมบูรณ์ - รีเทิร์น?
        static void Work04() {
            Console.Write("Please input number: ");
            int num = int.Parse(Console.ReadLine());
            
            int output = (num ^ (num >> 31)) - (num >> 31);
            Console.WriteLine(output);
        }

         // Work05  อ้ายมา 5 คน
        static void Work05() {
            Console.Write("Please input number: ");
            int num = int.Parse(Console.ReadLine());
            int max = 8;

            for (int i = 1; i <= 4;i++) {
                int output = ((num + (i-1)) % max);
                Console.WriteLine(++output);
            } 
        }


         // Work06  BTS ที่ไม่ใช่ชื่อวงดนตรี 
        static void Work06() {
            Console.Write("Please input a number of stations: ");
            int num = int.Parse(Console.ReadLine());
            int cost = 0;
            switch (num) {
                case 1:
                    cost = 16;
                    break;
                case 2:
                    cost = 23;
                    break;  
                case 3:
                    cost = 26;
                    break; 
                case 4:
                    cost = 30;
                    break;
                case 5:
                    cost = 33;
                    break; 
                case 6:
                    cost = 37;
                    break;        
                case 7:
                    cost = 40;
                    break; 
                default:
                    if (num >= 8 && num <= 15) {
                        cost = 44;
                    } else {
                        cost = 59;
                    }
                    break;                       
            }
            Console.WriteLine("Cost (THB): "+cost);
        }

        
         // Work07  เผื่อไปเที่ยว (⭐⭐⭐)
        static void Work07() {
            Console.Write("Please input year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Please input month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Please input day: ");
            int day = int.Parse(Console.ReadLine());

            if (
                ((year == 1868 && month == 9  && day >= 8 ) || (year == 1868 && month > 9) || (year > 1868 )) &&
                ((year == 1912 && month == 7  && day <= 29 ) || (year == 1912 && month < 7) || (year < 1912 ))
                ) {
                Console.Write("Maji");
            } else if (
                ((year == 1912 && month == 7  && day >= 30 ) || (year == 1912 && month > 1) || (year > 1912 )) &&
                ((year == 1926 && month == 12  && day <= 24 ) || (year == 1926 && month < 12) || (year < 1926 ))
                ) {
                Console.Write("Taisho");
            } else if (
                ((year == 1926 && month == 12  && day >= 25 ) || (year == 1989 && month > 12) || (year > 1926 )) &&
                ((year == 1989 && month == 1  && day <= 7 ) || (year == 1989 && month < 1) || (year < 1989 ))
                ) {
                Console.Write("Showa");
            } else if (
               ((year == 1989 && month == 1  && day >= 8 ) || (year == 1989 && month > 1) || (year > 1989 )) &&
                ((year == 2019 && month == 4  && day <= 30 ) || (year == 2019 && month < 4) || (year < 2019 ))
                ) {
                Console.Write("Heisei");
            } else if(((year == 2019 && month == 5  && day >= 1 ) || (year == 2019 && month > 5) || (year > 2019 ))) {
                Console.Write("Reiwa");
            }
        }


        // Work08  อย่างสีเหลือง  (⭐⭐)
        static void Work08() {
            Console.Write("Disaster Level: ");
            int level = int.Parse(Console.ReadLine());

            string binary = Convert.ToString(level, 2);
            //Console.WriteLine(binary);

            int show = Convert.ToInt32(binary);

            if (show % 10 == 1) {
                Console.WriteLine("Yellow");
            }
            if ((show % 100)/10 == 1) {
                Console.WriteLine("Orange");
            }
            if ((show % 1000)/100 == 1) {
                Console.WriteLine("Red");
            }
        }

     // Work09  Shopzada และ Lapee (⭐)
        static void Work09() {
            Console.Write("Count: ");
            int Count = int.Parse(Console.ReadLine());
            Console.Write("Rate: ");
            int Rate = int.Parse(Console.ReadLine());

            int price = 50;
            
            int lapee = ((Count) * price) / (Count + 1);
            int shopzada =  (price - ((price* Rate)/100) ) ;
            
            Console.WriteLine(lapee + " " + shopzada);

            if (lapee < shopzada) {
                Console.WriteLine("Lapee");
            } else if (lapee > shopzada) {
                Console.WriteLine("shopzada");
            } else {
                Console.WriteLine("E-mazon");
            }
        }

    //Work10 Double door (⭐)
        static void Work10() {
            Console.Write("Input even number: ");
            string num = Console.ReadLine();
            int realNum = 0;
            bool surcess = int.TryParse(num, out realNum); 

            if (!surcess) {
                Console.WriteLine("Pls input intiger");
            } else  if (realNum <= 0) {
                Console.WriteLine("Please input a positive integer.");
            } else  if (realNum % 2 == 1 && realNum > 0)  {
                Console.WriteLine("Please input an even positive integer.");
            } else  if ( realNum % 2 == 0 && realNum > 0) {
                Console.WriteLine(realNum/2 + ", "+ ((realNum/2) + 1));
            }

        }

         //Work10 11. To loop, or not to loop (⭐⭐)
        static void Work11() {
            Console.Write("Input count: ");
            int count = int.Parse(Console.ReadLine());

            string hamlet = string.Join("\n", Enumerable.Repeat("hamlet", count));
            Console.WriteLine(hamlet);
    
        }

         //Work12 12. เหลี่ยมจัด (⭐⭐)
        static void Work12() {
            Console.Write("Input High: ");
            int n = int.Parse(Console.ReadLine());
            int count = (n * ((4 * (n*n)) - 1) / 3);
            Console.WriteLine( count );
    
        }

       
        //Work13 13. หารร่วมมาก - รีเทิร์น? (⭐⭐⭐)
        static void Work13() {
            Console.Write("Input Count: ");
            int Count = int.Parse(Console.ReadLine());
           
            int great_common_factor = 0;

            for (int i = 1;i <= Count;i++) {
                Console.Write("Input number"+i+": ");
                int number = int.Parse(Console.ReadLine());
                 
                if (great_common_factor == 0){
                    great_common_factor = number;
                }
                int c = great_common_factor;
                for (int x = 1;x <= number;x++) {
                    if ( (great_common_factor % x == 0) && (number % (x) == 0) && x <= great_common_factor){
                        c = x;
                    }
                }
                great_common_factor = c;
                Console.WriteLine("great common factor:"+great_common_factor);

            }
            

        }

        //Work14  14. ยังไม่จบกับพีระมิด (⭐)
        static void Work14() {
            Console.Write("Input High: ");
            int High = int.Parse(Console.ReadLine());
            int Base = (High * 2) - 1;
               
            for (int h = 1;h<=High;h++){

                if (h == High) {
                    for (int r = 1;r<=Base;r++){
                      Console.Write("#");  
                    }
                } else {
                    for (int r = 1;r<=Base;r++){
                        if (r == High + (h-1) || r == High - (h-1)){
                            Console.Write("#");  
                        } else {
                            Console.Write(" ");  
                        }

                    }
                }
                Console.WriteLine();
                
            }
        }

        //Work15 15. นายนอนดี ใจดี (⭐)
        static void Work15() {
           

            int oldest_y = 0;
            int newest_y = 0;
            string oldest_rank = "";
            string newest_rank = "";
            
            while (true) {
                Console.Write("Input Rank: ");
                string rank = Console.ReadLine();
                Console.Write("Input Year: ");
                int year = int.Parse(Console.ReadLine());

                if (oldest_y == 0) {
                    oldest_y = year;
                }
                if (year < 2565 && year > newest_y) {
                    newest_y = year;
                    newest_rank = rank;
                } else if (year < 2565 &&  year < oldest_y){
                    oldest_y = year;
                    oldest_rank = rank;

                } else if (year == 2565){
                    newest_y = year;
                    newest_rank = rank;
                    break;
                }

            } 

            Console.WriteLine("Oldest Rank: {0} {1}",oldest_rank,oldest_y);
            Console.WriteLine("Newest Rank: {0} {1}",newest_rank,newest_y);
            Console.WriteLine("Service age: {0}",(newest_y - oldest_y) + 1);
    
        }
        

        static void Main(string[] args) {
            Work15();
        }
    }
}