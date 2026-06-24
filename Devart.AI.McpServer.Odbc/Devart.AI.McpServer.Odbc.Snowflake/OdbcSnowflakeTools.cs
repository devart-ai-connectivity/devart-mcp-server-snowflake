// --------------------------------------------------------------------------
// <copyright file="OdbcSnowflakeTools.cs" company="Devart">
//
// Copyright (c) Devart. ALL RIGHTS RESERVED
// Use of the source code is permitted under the license.
// </copyright>
// --------------------------------------------------------------------------

using System.Collections.Generic;
using ModelContextProtocol.Server;
using Devart.AI.McpServer.Odbc.Snowflake.Tools;

namespace Devart.AI.McpServer.Odbc.Snowflake
{
  internal static class OdbcSnowflakeTools
  {
    public static List<McpServerTool> CreateTools(McpConfiguration configuration)
      => OdbcTools.CreateBuilder(configuration)
        .Add(new OdbcSnowflakePrimaryKeysTool(configuration))
        .Add(new OdbcSnowflakeForeignKeysTool(configuration))
        .Build();
  }
}
