using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CompanyCatalog
{
    public class CompanyViewModel
    {
        public ObservableCollection<Company> Company { get; set; }
        private CompanyRepository CompanyRepository { get; set; }

        public CompanyViewModel()
        {
            CompanyRepository = new CompanyRepository();
            Company = new ObservableCollection<Company>(CompanyRepository.companyRepository);
            Company.CollectionChanged += Company_CollectionChanged;      
        }

        public List<Company> searchRepo(string searchQuery)
        {
            if (searchQuery == "*" || searchQuery == " ")
                throw new Exception("Warning: Symbols such as '*' or whitespace are not acceptable");

            List<Company> CompanyList =                
                (from tempCompany in Company
                 where tempCompany.CompanyName.Contains(searchQuery)
                 select tempCompany).ToList();
            return CompanyList;
        }

        public void AddRecordToRepo(Company company)
        {
            if (company == null)
                throw new ArgumentNullException("Error: The argument is Null");
            Company.Add(company);
        }

        public void DeleteRecordFromRepo(int id)
        {
            if (id < 0)
                throw new Exception("Record ID must be non-negative");

            int index = 0;
            while (index < Company.Count)
            {
                if (Company[index].Id == id)
                {
                    Company.RemoveAt(index);
                    break;
                }
                index++;
            }
        }

        public void UpdateRecordInRepo(Company company)
        {
            if (company.Id < 0)
                throw new Exception("Error: ID cannot be negative");

            int index = 0;
            while (index < Company.Count)
            {
                if (Company[index].Id == company.Id)
                {
                    Company[index] = company;
                    break;
                }
                index++;
            }
        }

        private void Company_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                int newIndex = e.NewStartingIndex;
                CompanyRepository.addNewRecord(Company[newIndex]);
            }
            else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                List<Company> tempListOfRemovedItems = e.OldItems.OfType<Company>().ToList();
                CompanyRepository.DelRecord(tempListOfRemovedItems[0].Id);
            }
            else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Replace)
            {
                List<Company> tempListOfCompany = e.NewItems.OfType<Company>().ToList();
                CompanyRepository.UpdateRecord(tempListOfCompany[0]);      
            }
        }
    }
}
