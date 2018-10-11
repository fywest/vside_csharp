using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//付款接口
public interface IPayment
    {
        bool Payment(double pay);
       
    }
