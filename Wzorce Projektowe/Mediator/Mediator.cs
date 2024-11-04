using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.MediatorSpace
{
    interface IMediator
    {
        void Notify(object sender);
    }

    class Mediator : IMediator
    {
        readonly OrderReceiver _receiver;
        readonly OrderVerifier _verifier;
        readonly OrderProcesser _processer;
        readonly OrderLogger _logger;
        OrderState _state = OrderState.Pending;


        public Mediator(OrderReceiver receiver, OrderVerifier verifier, OrderProcesser processer, OrderLogger logger)
        {
            _receiver = receiver;
            _verifier = verifier;
            _processer = processer;
            _logger = logger;
        }

        public void Notify(object sender)
        {
            if (sender == _receiver) _state = OrderState.Received;
            if (sender == _verifier) _state = _verifier.VerificationState;
            if (sender == _processer)
            {
                if (_state == OrderState.Rejected)
                    Console.WriteLine("Cant process order");
                else _state = OrderState.Completed;
            }
            _logger.Log(_state);
        }
    }

    class OrderReceiver
    {
        public IMediator Mediator { get; set; }

        public void ReceiveOrder()
        {
            Mediator.Notify(this);
        }
    }
    class OrderVerifier
    {
        public IMediator Mediator { get; set; }
        public OrderState VerificationState { get; set; }

        public void VerifyOrder()
        {
            Random verificator = new Random();
            if (verificator.Next(2) == 0)
                VerificationState = OrderState.Accepted;
            else VerificationState = OrderState.Rejected;
            Mediator.Notify(this);
        }
    }

    class OrderProcesser
    {
        public IMediator Mediator { get; set; }
        public void ProcessOrder()
        {
            Mediator.Notify(this);
        }
    }
    class OrderLogger
    {
        public void Log(OrderState state)
        {
            Console.WriteLine("Current state: " + state);
        }
    }

    enum OrderState
    {
        Pending,
        Received,
        Accepted,
        Rejected,
        Completed,
    }

}
