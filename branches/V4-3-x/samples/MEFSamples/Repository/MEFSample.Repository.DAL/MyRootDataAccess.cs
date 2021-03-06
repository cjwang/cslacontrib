﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using MEFSample.Business.Repository;

namespace MEFSample.Respository.DAL
{

  [Export(typeof(IRootDataAccess))]
  public class MyRootDataAccess : IRootDataAccess
  {
    public RootData Get(int id)
    {
      return new RootData() { Id = id, Name = "Ole Olsen" };
    }
  }
}
