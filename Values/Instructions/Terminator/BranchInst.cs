﻿namespace LLVMSharp
{
    public sealed class BranchInst : TerminatorInst
    {
        internal BranchInst(LLVMValueRef instance)
            : base(instance)
        {
        }

        public bool IsConditional
        {
            get { return LLVM.IsConditional(this.Unwrap()); }
        }

        public bool IsUnconditional
        {
            get { return !this.IsConditional; }
        }

        public Value Condition
        {
            get { return LLVM.GetCondition(this.Unwrap()).Wrap<Value>(); }
            set { LLVM.SetCondition(this.Unwrap(), value.Unwrap()); }
        }
    }
}