using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFstudii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InsertData1()
        {
            using(var context = new ModelSelfRefrences())
            {
                var selfreference = new SelfReference
                {
                    Name = "Test"
                    
                };
                context.SelfReferences.Add(selfreference);
                context.SaveChanges();
            }
         

        }

        private void PrintData1()
        {
            using (var context = new ModelSelfRefrences())
            {

                foreach (var p in context.SelfReferences)
                {
                    var txt = String.Format("{0}\n", p.Name);
                    Console.WriteLine("{0}", p.Name);
                    textBox1.Text += p.Name;
                }
            }

        }

        private void InsertData2()
        {
            using (var context = new ProductContext())
{
                var product = new Product
                {
                    SKU = 147,
                    Description = "Expandable Hydration Pack",
                    Price = 19.97M,
                    ImageURL = "/pack147.jpg"
                };
                context.Products.Add(product);
                product = new Product
                {
                    SKU = 178,
                    Description = "Rugged Ranger Duffel Bag",
                    Price = 39.97M,
                    ImageURL = "/pack178.jpg"
                };
                context.Products.Add(product);
                product = new Product
                {
                    SKU = 186,
                    Description = "Range Field Pack",
                    Price = 98.97M,
                    ImageURL = "/noimage.jp"
                };
                context.Products.Add(product);
                product = new Product
                {
                    SKU = 202,
                    Description = "Small Deployment Back Pack",
                    Price = 29.97M,
                    ImageURL = "/pack202.jpg"
                };
                context.Products.Add(product);
                context.SaveChanges();
            }
           
        }

        private void PrintData2()
        {
            using (var context = new ProductContext())
            {
                foreach (var p in context.Products)
                {
                    var data = String.Format("{0} {1} {2} {3}\n", p.SKU, p.Description,
                    p.Price.ToString("C"), p.ImageURL);
                    Console.WriteLine("{0} {1} {2} {3}", p.SKU, p.Description,
                    p.Price.ToString("C"), p.ImageURL);
                    textBox1.Text += data;
                }
            }
        }
    
        private void InsertData3()
        {
            byte[] thumbBits = new byte[100];
            byte[] fullBits = new byte[2000];
            using (var context = new ModelPhotograph())
{
                var photo = new Photograph
                {
                    Title = "My Dog",
                    ThumbnailBits = thumbBits
                };
                var fullImage = new PhotographFullImage
                {
                    HighResolutionBits = fullBits
                };

                photo.PhotographFullImage = fullImage;
                context.Photo.Add(photo);
                context.SaveChanges();
            }
            
        }


        private void PrintData3()
        {
            using (var context = new ModelPhotograph())
            {
                foreach (var photo in context.Photo)
                {
                    var data = String.Format("Photo: {0}, ThumbnailSize {1} bytes\n",
                    photo.Title, photo.ThumbnailBits.Length);

                    textBox1.Text += data;
                    Console.WriteLine("Photo: {0}, ThumbnailSize {1} bytes",
                    photo.Title, photo.ThumbnailBits.Length);


                    // explicitly load the "expensive" entity,
                    context.Entry(photo).Reference(p => p.PhotographFullImage).Load();

                    Console.WriteLine("Full Image Size: {0} bytes",
                        photo.PhotographFullImage.HighResolutionBits.Length);
                    data = String.Format("Full Image Size: {0} bytes",
                        photo.PhotographFullImage.HighResolutionBits.Length);
                    textBox1.Text += data;
                }
            }
        }

        private void InsertData4()
        {
            using (var context = new ModelBusiness())
{
                var business = new Business
                {
                    Name = "Corner Dry Cleaning",
                    LicenseNumber = "100x1"
                };
                context.Businesses.Add(business);
                var retail = new Retail
                {
                    Name = "Shop and Save",
                    LicenseNumber =
                "200C",
                    Address = "101 Main",
                    City = "Anytown",
                    State = "TX",
                    ZIPCode = "76106"
                };
                context.Businesses.Add(retail);
                var web = new eCommerce
                {
                    Name = "BuyNow.com",
                    LicenseNumber =
                "300AB",
                    URL = "www.buynow.com"
                };
                context.Businesses.Add(web);
                context.SaveChanges();
            }
            
        }
    
        private void PrintData4()
        {
            using (var context = new ModelBusiness())
            {
                var data = String.Format("\n--- All Businesses ---\n");
                Console.WriteLine("\n--- All Businesses ---\n");
                textBox1.Text += data;
                foreach (var b in context.Businesses)
                {
                    data = String.Format("{0} (#{1})", b.Name, b.LicenseNumber);
                    Console.WriteLine("{0} (#{1})", b.Name, b.LicenseNumber);
                    textBox1.Text += data;
                }
                Console.WriteLine("\n--- Retail Businesses ---");
                textBox1.Text += "\n--- Retail Businesses ---";
                foreach (var r in context.Businesses.OfType<Retail>())
                {
                    data = String.Format("{0} (#{1})", r.Name, r.LicenseNumber);
                    textBox1.Text += data;
                    Console.WriteLine("{0} (#{1})", r.Name, r.LicenseNumber);
                    data = String.Format("{0}", r.Address);
                    textBox1.Text += data;
                    Console.WriteLine("{0}", r.Address);
                    data = String.Format("{0}, {1} {2}", r.City, r.State, r.ZIPCode);
                    textBox1.Text += data;
                    Console.WriteLine("{0}, {1} {2}", r.City, r.State, r.ZIPCode);
                }
                textBox1.Text += "\n--- eCommerce Businesses ---";
                Console.WriteLine("\n--- eCommerce Businesses ---");
                foreach (var e in context.Businesses.OfType<eCommerce>())
                {
                    data = String.Format("{0} (#{1})", e.Name, e.LicenseNumber);
                    textBox1.Text += data;
                    Console.WriteLine("{0} (#{1})", e.Name, e.LicenseNumber);
                    data = String.Format("Online address is: {0}", e.URL);
                    textBox1.Text += data;
                    Console.WriteLine("Online address is: {0}", e.URL);
                }
            }
        }
        private void InsertData5()
        {
            using (var context = new EmployeeModel())
{
                var fte = new FullTimeEmployee
                {
                    FirstName = "Jane",
                    LastName =
                "Doe",
                    Salary = 71500M
                };
                context.Employees.Add(fte);
                fte = new FullTimeEmployee
                {
                    FirstName = "John",
                    LastName = "Smith",
                    Salary = 62500M
                };
                context.Employees.Add(fte);
                var hourly = new HourlyEmployee
                {
                    FirstName = "Tom",
                    LastName =
                "Jones",
                    Wage = 8.75M
                };
                context.Employees.Add(hourly);
                context.SaveChanges();
            }
            
        }
        
        private void PrintData5()
        {
            using (var context = new EmployeeModel())
            {
                var data = String.Format("-- - All Employees-- - ");
                textBox1.Text +=data  ;
                Console.WriteLine("--- All Employees ---");
                foreach (var emp in context.Employees)
                {
                    bool fullTime = emp is HourlyEmployee ? false : true;
                    data = String.Format("{0} {1} ({2})", emp.FirstName, emp.LastName,
                    fullTime ? "Full Time" : "Hourly");
                    textBox1.Text += data;
                    Console.WriteLine("{0} {1} ({2})", emp.FirstName, emp.LastName,
                    fullTime ? "Full Time" : "Hourly");
                }
                Console.WriteLine("--- Full Time ---");
                textBox1.Text += "--- Full Time ---";
                foreach (var fte in context.Employees.OfType<FullTimeEmployee>())
                {
                    Console.WriteLine("{0} {1}", fte.FirstName, fte.LastName);
                    data = String.Format("{0} {1}", fte.FirstName, fte.LastName);
                    textBox1.Text += data;
                }
                Console.WriteLine("--- Hourly ---");
                textBox1.Text += "--- Hourly ---- ";
                foreach (var hourly in context.Employees.OfType<HourlyEmployee>())
                {
                    Console.WriteLine("{0} {1}", hourly.FirstName,
                    hourly.LastName);
                    data = String.Format("{0} {1}", hourly.FirstName,
                    hourly.LastName);
                    textBox1.Text += data;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            PrintData1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            PrintData2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            PrintData3();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            PrintData4();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            PrintData5();
        }
    }
}
