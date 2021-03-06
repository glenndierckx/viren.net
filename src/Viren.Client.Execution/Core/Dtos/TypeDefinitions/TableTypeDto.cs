using System.Collections.Generic;
using Viren.Client.Execution.Core.Enums;

namespace Viren.Client.Execution.Core.Dtos.TypeDefinitions
{
    public class TableTypeDto : TypeDefinition
    {
        public IList<PropertyInfoDto> Properties { get; set; }

        public IList<KeyDto> Keys { get; set; }

        public override TypeKind TypeKind => TypeKind.Table;
    }
}