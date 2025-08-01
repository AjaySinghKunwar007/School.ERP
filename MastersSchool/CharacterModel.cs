using System.Security.Principal;

namespace Optimum.ERP.Models.Masters
{
    public class CharacterModel
    {
        public int CharacterCode { get; set; }
        public string CharacterName { get; set; }

    }
    public class CharacterFiltterModel
    {
        public int? CharacterCode { get; set; }
        public string CharacterName { get; set; }
    }
}
