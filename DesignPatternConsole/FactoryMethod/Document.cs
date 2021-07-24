using System;
using System.Collections.Generic;

namespace DesignPatternConsole.FactoryMethod
{
    // Document is the creator abstract class
    abstract class Document
    {
        private List<Page> pages = new List<Page>();

        // Cons calls abstract factory method
        public Document()
        {
            this.CreatePages();
        }

        // The Factory Method
        public abstract void CreatePages();

        public List<Page> Pages
        {
            get { return pages; }
        }
    }

    // Resume is a ConcreteCreator
    internal class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }

    // Report is a ConcreteCreator
    internal class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new RefferencePage());
        }
    }
}