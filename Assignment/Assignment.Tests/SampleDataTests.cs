﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Tests;

[Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
public class SampleDataTests
{
    [TestMethod]
    public void CSVRows()
    {
        SampleData sample = new();
        List<string> rows = (List<string>)sample.CsvRows;

        Assert.AreEqual<string>("1,Priscilla,Jenyns,pjenyns0@state.gov,7884 Corry Way,Helena,MT,70577", rows[0]);
       
    }

    [TestMethod]
    public void UniqueSortedListofStates()
    {
        SampleData sample = new();
        
        IEnumerable<string> states = sample.GetUniqueSortedListOfStatesGivenCsvRows();

        Assert.AreEqual<string>("AL", states.First());
        Assert.AreEqual<string>("WV", states.Last());   
    }

    [TestMethod]
    public void UniqueSortedListString()
    {
        SampleData sample = new();

        string states = sample.GetAggregateSortedListOfStatesUsingCsvRows();

        Assert.AreEqual<string>("AL, AZ, CA, DC, FL, GA, IN, KS, LA, MD, MN, MO, MT, NC, " +
                                "NE, NH, NV, NY, OR, PA, SC, TN, TX, UT, VA, WA, WV", states);
    }

    [TestMethod]
    public void PeopleReturnsAPerson()
    {
        SampleData sample = new();

        Assert.IsInstanceOfType(sample.People, typeof(IEnumerable<Person>));
    }

    [TestMethod]
    public void ListOfPeopleIsSorted()
    {
        SampleData sample = new();
        List<IPerson> testPeople = sample.People.ToList();

        Assert.AreEqual<string>("AL", testPeople.First().Address.State);
        Assert.AreEqual<string>("WV", testPeople.Last().Address.State);

    }

    [TestMethod]
    public void FilterWorks()
    {
        SampleData sample = new();

        //Predicate<string> test = sample.FilterByEmailAddress(delegate("pjenyns0@state.gov"));

        //Priscilla,Jenyns,pjenyns0@state.gov
        //IEnumerable<(string, string)> name = ("Priscilla", "Jenyns");
        List<IPerson> name = sample.People.ToList();
        Predicate<string> email = (string e) => { return e == "pjenyns0@state.gov"; };
        Assert.AreEqual<IEnumerable<(string, string)>>((name.First().FirstName, name.First().LastName) as IEnumerable<(string, string)>, sample.FilterByEmailAddress(email));
    }
}
