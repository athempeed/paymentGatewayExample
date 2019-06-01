using Hangfire;
using PaymentGatewayApp.Jobs.interfaces;
using PaymentGatewayApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentGatewayApp.Jobs
{
    public class ReportJob : IReportJob
    {

        private AppDBContext _dbcontext;
        
        public ReportJob(AppDBContext dBContext)
        {
            _dbcontext = dBContext;
        }

        public async Task Run(IJobCancellationToken token)
        {
            token.ThrowIfCancellationRequested();
            await RunAtTimeOf(DateTime.Now);
        }

        public Task RunAtTimeOf(DateTime dateTime)
        {

            TODO://
            throw new NotImplementedException();
        }
    }
}
