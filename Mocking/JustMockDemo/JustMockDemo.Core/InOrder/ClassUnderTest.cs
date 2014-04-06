namespace JustMockDemo.Core.InOrder
{
    public class ClassUnderTest
    {
        readonly IInOrderDependency _sequentialDependency;

        public ClassUnderTest(IInOrderDependency sequentialDependency)
        {
            _sequentialDependency = sequentialDependency;
        }

        public bool TestMe()
        {
            _sequentialDependency.First();
            _sequentialDependency.Second();
            _sequentialDependency.Second();
            //_sequentialDependency.Third();
            return true;
        }
    }
}