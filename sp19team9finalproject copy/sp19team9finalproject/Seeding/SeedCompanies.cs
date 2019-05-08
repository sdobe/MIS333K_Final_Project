using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sp19team9finalproject.DAL;
using sp19team9finalproject.Models;

namespace sp19team9finalproject.Seeding
{
    public static class SeedCompanies
    {
        public static void SeedAllCompanies(AppDbContext db)
        {
            if (db.Companies.Count() == 13)
            {
                NotSupportedException ex = new NotSupportedException("Already 13 Companies");

                throw ex;
            }

            Int32 intCompaniesAdded = 0;
            List<Company> Companies = new List<Company>();


            try
            {

                Company c1 = new Company()
                {
                    EmailAddress = "accenture@example.com",
                    Description = "Accenture is a global management consulting, technology services and outsourcing company.",
                    Name = "Accenture",
                    Industry = "Consulting, Technology"
                };
                Companies.Add(c1);

                Company c2 = new Company()
                {
                    EmailAddress = "shell@example.com",
                    Description = "Shell Oil Company, including its consolidated companies and its share in equity companies, is one of America's leading oil and natural gas producers, natural gas marketers, gasoline marketers and petrochemical manufacturers.",
                    Name = "Shell", 
                    Industry = "Energy, Chemicals"
                };
                Companies.Add(c2);

                Company c3 = new Company()
                {
                    EmailAddress = "deloitte@example.com",
                    Description = "Deloitte is one of the leading professional services organizations in the United States specializing in audit, tax, consulting, and financial advisory services with clients in more than 20 industries.",
                    Name = "Deloitte",
                    Industry = "Accounting, Consulting, Technology"
                };
                Companies.Add(c3);

                Company c4 = new Company()
                {
                    EmailAddress = "capitalone@example.com",
                    Description = "Capital One offers a broad spectrum of financial products and services to consumers, small businesses and commercial clients.",
                    Name = "Capital One",
                    Industry = "Financial Services"
                };
                Companies.Add(c4);

                Company c5 = new Company()
                {
                    EmailAddress = "texasinstruments@example.com",
                    Description = "TI is one of the world’s largest global leaders in analog and digital semiconductor design and manufacturing",
                    Name = "Texas Instruments",
                    Industry = "Manufacturing"
                };
                Companies.Add(c5);

                Company c6 = new Company()
                {
                    EmailAddress = "hiltonworldwide@example.com",
                    Description = "Hilton Worldwide offers business and leisure travelers the finest in accommodations, service, amenities and value.",
                    Name = "Hilton Worldwide",
                    Industry = "Hospitality"
                };
                Companies.Add(c6);

                Company c7 = new Company()
                {
                    EmailAddress = "aon@example.com",
                    Description = "Aon is the leading global provider of risk management, insurance and reinsurance brokerage, and human resources solutions and outsourcing services.",
                    Name = "Aon",
                    Industry = "Insurance, Consulting"
                };
                Companies.Add(c7);

                Company c8 = new Company()
                {
                    EmailAddress = "adlucent@example.com",
                    Description = "Adlucent is a technology and analytics company specializing in selling products through the Internet for online retail clients.",
                    Name = "Adlucent",
                    Industry = "Marketing, Technology"
                };
                Companies.Add(c8);

                Company c9 = new Company()
                {
                    EmailAddress = "streamrealtypartners@example.com",
                    Description = "Stream Realty Partners, L.P. (Stream) is a national, commercial real estate firm with locations across the country.",
                    Name = "Stream Realty Partners",
                    Industry = "Real-Estate"
                };
                Companies.Add(c9);

                Company c10 = new Company()
                {
                    EmailAddress = "microsoft@example.com",
                    Description = "Microsoft is the worldwide leader in software, services and solutions that help people and businesses realize their full potential.",
                    Name = "Microsoft",
                    Industry = "Technology"
                };
                Companies.Add(c10);

                Company c11 = new Company()
                {
                    EmailAddress = "academysports@example.com",
                    Description = "Academy Sports is intensely focused on being a leader in the sporting goods, outdoor and lifestyle retail arena",
                    Name = "Academy Sports & Outdoors",
                    Industry = "Retail"
                };
                Companies.Add(c11);

                Company c12 = new Company()
                {
                    EmailAddress = "unitedairlines@example.com",
                    Description = "United Airlines has the most modern and fuel-efficient fleet (when adjusted for cabin size), and the best new aircraft order book, among U.S. network carriers",
                    Name = "United Airlines",
                    Industry = "Transportation"
                };
                Companies.Add(c12);

                Company c13 = new Company()
                {
                    EmailAddress = "target@example.com",
                    Description = "Target is a leading retailer",
                    Name = "Target",
                    Industry = "Retail"
                };
                Companies.Add(c13);

                try
                {
                    foreach (Company companyToAdd in Companies)
                    {

                        Company dbCompany = db.Companies.FirstOrDefault(m => m.Name == companyToAdd.Name);

                        if (dbCompany == null)
                        {
                            db.Companies.Add(companyToAdd);
                            db.SaveChanges();
                            intCompaniesAdded += 1;
                        }
                        else
                        {
                            dbCompany.Name = companyToAdd.Name;
                            dbCompany.EmailAddress = companyToAdd.EmailAddress;
                            dbCompany.Description = companyToAdd.Description;
                            dbCompany.Industry = companyToAdd.Industry;
                            db.Update(dbCompany);
                            db.SaveChanges();
                            intCompaniesAdded += 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    String msg = " Repositories added:" + intCompaniesAdded + "; ";

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
