﻿using OpenSpaceCodeGen.Translation;

namespace OpenSpaceCodeGen.Nodes {
    public class NodeDsgVarRef : Node {

        protected override NodeTranslator GetTranslator(CodeGenerator gen)
        {
            return NodeTranslator.Sequence("DsgVar_"+param);
        }

        public override string ToString(CodeGenerator gen)
        {
            return this.GetType().Name;
        }
    }
}
