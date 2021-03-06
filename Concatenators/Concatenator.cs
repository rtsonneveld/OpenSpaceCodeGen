﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenSpaceCodeGen.Translation;

namespace OpenSpaceCodeGen.Concatenators {
    public abstract class Concatenator
    {
        public abstract string ConcatenateScripts(string[] scripts, string name);
        public abstract string ConcatenateBehaviours(string[] behaviours);
        public abstract string ConcatenateAIModel(string modelName, string rules, string reflexes);

        private static readonly Dictionary<LanguageTranslation.TranslationMode, Concatenator> _mapping =
            new Dictionary<LanguageTranslation.TranslationMode, Concatenator>()
            {
                {LanguageTranslation.TranslationMode.CSharp, new ConcatenatorCSharp()},
                {LanguageTranslation.TranslationMode.Raw, new ConcatenatorRaw()},
            };

        public static Concatenator FromMode(LanguageTranslation.TranslationMode mode) => _mapping[mode];
    }
}
