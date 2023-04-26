namespace LearnReferences;

public interface IFlippable
{
   int CurrentPage { get; set; }
   void Flip();
}