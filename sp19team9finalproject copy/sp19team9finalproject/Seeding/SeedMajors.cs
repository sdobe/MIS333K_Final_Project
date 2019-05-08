using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sp19team9finalproject.DAL;
using sp19team9finalproject.Models;

namespace sp19team9finalproject.Seeding
{
    public class SeedMajors
    {
        public static void SeedAllMajors(AppDbContext db)
        {
            if (db.Majors.Count() == 9)
            {
                NotSupportedException ex = new NotSupportedException("Already 9 Majors");

                throw ex;
            }

            Int32 intMajorsAdded = 0;
            List<Major> Majors = new List<Major>();


            try
            {
                Major m1 = new Major()
                {
                    Name = "MIS"
                };
                Majors.Add(m1);

                Major m2 = new Major()
                {
                    Name = "Finance"
                };
                Majors.Add(m2);

                Major m3 = new Major()
                {
                    Name = "Accounting"
                };
                Majors.Add(m3);

                Major m4 = new Major()
                {
                    Name = "Business Honors"
                };
                Majors.Add(m4);

                Major m5 = new Major()
                {
                    Name = "Science and Technology Management"
                };
                Majors.Add(m5);

                Major m6 = new Major()
                {
                    Name = "Management"
                };
                Majors.Add(m6);

                Major m7 = new Major()
                {
                    Name = "Marketing"
                };
                Majors.Add(m7);

                Major m8 = new Major()
                {
                    Name = "Supply Chain Management"
                };
                Majors.Add(m8);

                Major m9 = new Major()
                {
                    Name = "International Business"
                };
                Majors.Add(m9);

                try
                {
                    foreach (Major majorToAdd in Majors)
                    {
                        string strMajorName = majorToAdd.Name;
                        Major dbMajor = db.Majors.FirstOrDefault(m => m.Name == majorToAdd.Name);

                        if (dbMajor == null)
                        {
                            db.Majors.Add(majorToAdd);
                            db.SaveChanges();
                            intMajorsAdded += 1;
                        }
                        else
                        {
                            dbMajor.Name = majorToAdd.Name;
                        }
                    }
                }
                catch (Exception ex)
                {
                    String msg = " Repositories added:" + intMajorsAdded + "; ";

                    throw new InvalidOperationException(ex.Message + msg);

                }
            }

            catch (Exception e)
            {
                throw new InvalidOperationException(e.Message);
            }
        }
    }
}
