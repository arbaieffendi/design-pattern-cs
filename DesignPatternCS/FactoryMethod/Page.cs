namespace DesignPatternCS.FactoryMethod
{
    // here we define the interface of objects the factory method creates

    /// <summary>
    /// The Product abstract class
    /// </summary>
    abstract class Page
    {
    }

    // Below are the concrete product class
    class SkillsPage : Page { }

    class EducationPage : Page { }

    class ExperiencePage : Page { }

    class IntroductionPage : Page { }

    class ResultsPage : Page { }

    class ConclusionPage : Page { }

    class SummaryPage : Page { }

    class RefferencePage : Page { }

}