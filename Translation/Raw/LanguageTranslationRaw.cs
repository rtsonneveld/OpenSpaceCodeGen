﻿using OpenSpaceCodeGen.Nodes;

namespace OpenSpaceCodeGen.Translation.Raw
{
    public class LanguageTranslationRaw : LanguageTranslation {

        public override NodeTranslator BasicTranslator(CodeGenerator gen, BasicNode node) =>
            NodeTranslator.RawTranslator(node, gen);
        public override NodeTranslator KeywordTranslator(CodeGenerator gen, NodeKeyWord node) =>
            NodeTranslator.RawTranslator(node, gen);
        public override NodeTranslator OperatorTranslator(CodeGenerator gen, NodeOperator node) =>
            NodeTranslator.RawTranslator(node, gen);
        public override NodeTranslator MetaActionTranslator(CodeGenerator gen, NodeMetaAction node) =>
            NodeTranslator.RawTranslator(node, gen);
        public override NodeTranslator FieldTranslator(CodeGenerator gen, NodeField node) =>
            NodeTranslator.RawTranslator(node, gen);
        public override NodeTranslator NullTranslator(CodeGenerator gen, NodeNull node) =>
            NodeTranslator.RawTranslator(node, gen);
        public override NodeTranslator ConditionTranslator(CodeGenerator gen, NodeCondition node) =>
            NodeTranslator.RawTranslator(node, gen);
        public override NodeTranslator ConstantTranslator(CodeGenerator gen, NodeConstant node) =>
            NodeTranslator.RawTranslator(node, gen);
        public override NodeTranslator RealTranslator(CodeGenerator gen, NodeReal node) =>
            NodeTranslator.RawTranslator(node, gen);
        public override NodeTranslator ProcedureTranslator(CodeGenerator gen, NodeProcedure node) =>
            NodeTranslator.RawTranslator(node, gen);
        public override NodeTranslator FunctionTranslator(CodeGenerator gen, NodeFunction node) =>
            NodeTranslator.RawTranslator(node, gen);
    }
}