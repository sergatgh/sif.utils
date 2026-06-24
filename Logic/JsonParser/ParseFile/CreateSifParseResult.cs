using AutoPipe;

namespace SIF.Utils.Logic.JsonParser.ParseFile
{
    public class CreateSifParseResult : AutoProcessor
    {
        public SifJsonParsingResult GetResult(Bag bag)
        {
            var result = new SifJsonParsingResult();
            if (bag.HasErrors())
            {
                result.Error = bag.Summary(filter: MessageFilter.Error);
            }

            if (bag.HasWarnings())
            {
                result.Warnings.AddRange(bag.Warnings());
            }

            bag.Update(result);
            return result;
        }
    }
}
