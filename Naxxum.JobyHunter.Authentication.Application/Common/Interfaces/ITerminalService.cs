﻿using Authentication.Application.Commands.Terminal.Create;
using Authentication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Application.Common.Interfaces
{
    public interface ITerminalService
    {
        void CreateTerminal(CreateTerminalCommand command);
        IEnumerable<Terminal> GetTerminals();
    }
}
