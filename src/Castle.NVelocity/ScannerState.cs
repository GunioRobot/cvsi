// Copyright 2007-2008 Jonathon Rossi - http://www.jonorossi.com/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Castle.NVelocity
{
    public enum ScannerState
    {
        Default,

        XmlComment,
        XmlTag,
        XmlTagAttributes,
        XmlTagAttributeValueDouble,
        XmlTagAttributeValueSingle,
        XmlCData,
        XmlScriptElementContent,

        NVMultilineComment,
        NVPreDirective,
        NVDirective,
        NVDirectiveParams,
        NVReference,
        NVReferenceSelectors,
        NVReferenceFormal,
        NVStringLiteralSingle,
        NVStringLiteralDouble,
        NVDictionary,
        NVDictionaryInner,
        NVParens,
        NVBracks
    }
}