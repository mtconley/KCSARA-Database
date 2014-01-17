﻿namespace Kcsara.Database.Services
{
  using System;
  using System.IO;
  using Kcsar.Database.Model;

  public interface IReportsService
  {
    Stream GetMissionReadyList(SarUnit unit);
    Stream GetMembershipReport();
  }
}
