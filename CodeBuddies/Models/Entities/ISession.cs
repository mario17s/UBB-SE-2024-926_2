
namespace CodeBuddies.Models.Entities
{
    public interface ISession
    {
        List<long> Buddies { get; set; }
        List<ICodeContribution> CodeContributions { get; set; }
        List<ICodeReviewSection> CodeReviewSections { get; set; }
        DateTime CreationDate { get; set; }
        IDrawingBoard DrawingBoard { get; set; }
        List<string> FilePaths { get; set; }
        long Id { get; set; }
        DateTime LastEditDate { get; set; }
        List<IMessage> Messages { get; set; }
        string Name { get; set; }
        long OwnerId { get; set; }
        ITextEditor TextEditor { get; set; }
    }
}