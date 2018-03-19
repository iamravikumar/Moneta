﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonetaFMS.Models
{
    public class Expense : Record
    {

        ExpenseCategory _category;
        public ExpenseCategory Category
        {
            get { return _category; }
            set { SetProperty(ref _category, value); }
        }

        string _description;
        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        decimal _totalCost;
        public decimal TotalCost
        {
            get { return _totalCost; }
            set { SetProperty(ref _totalCost, value); }
        }

        decimal _taxComponent;
        public decimal TaxComponent
        {
            get { return _taxComponent; }
            set { SetProperty(ref _taxComponent, value); }
        }

        DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { SetProperty(ref _date, value); }
        }

        string _imageReference;
        public string ImageReference
        {
            get { return _imageReference; }
            set { SetProperty(ref _imageReference, value); }
        }

        Invoice _invoice;
        public Invoice Invoice
        {
            get { return _invoice; }
            set { SetProperty(ref _invoice, value); }
        }

        [JsonConstructor]
        public Expense(int id, DateTime creation, string note, string description, ExpenseCategory category,
            DateTime date, decimal taxComponent, decimal totalCost, string imageReference, Invoice invoice)
            : this(note, description, category, date, taxComponent, totalCost, imageReference, invoice)
        {
            Id = id;
            CreationDate = creation;
        }

        public Expense(string note, string description, ExpenseCategory category, DateTime date,
            decimal taxComponent, decimal totalCost, string imageReference, Invoice invoice) : base()
        {
            Note = note;
            Description = description;
            Category = category;
            Date = date;
            TaxComponent = taxComponent;
            TotalCost = totalCost;
            ImageReference = imageReference;
            Invoice = invoice;

            if (Date == null || Date.Year == 1)
                Date = DateTime.Now;
        }
    }
}
