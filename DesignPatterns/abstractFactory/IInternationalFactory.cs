namespace DesignPatterns.abstractFactory;

public interface IInternationalFactory
{
    ILanguage createLanguage();
    ICapital createCapital();
}