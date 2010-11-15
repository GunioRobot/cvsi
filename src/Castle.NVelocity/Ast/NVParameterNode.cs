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

namespace Castle.NVelocity.Ast
{
    public class NVParameterNode : NVIdNode
    {
        private int _parNum;

        public NVParameterNode(string name, NVTypeNode type, int parNum)
            : base(name)
        {
            _type = type;
            _parNum = parNum;
        }

        public int ParNum
        {
            get { return _parNum; }
        }

        public override void DoSemanticChecks(ErrorHandler errs, Scope currentScope)
        {
            //TODO: _type = ResolveNamedTypeNodes(errs, currentScope, _type);
            base.DoSemanticChecks(errs, currentScope);
        }
    }
}