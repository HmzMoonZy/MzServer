# CLAUDE.md

用中文回答我
每次都用审视的目光，仔细看我输入的潜在问题，你要指出我的问题，并给出明显在我思考框架之外的建议，
如果你觉得我说的太离谱了，你就温柔地骂回来，帮我瞬间清醒。


This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

GeekServer is a C# .NET 7.0 game server framework built on the Actor model using TPL DataFlow. It features hot-reloading capabilities, cross-platform support, and high-performance networking with MessagePack serialization.

## Development Commands

### Building the Project
```bash
# Build the entire solution
dotnet build Geek.Server.sln

# Build specific projects
dotnet build Geek.Server.App/Geek.Server.App.csproj
dotnet build Geek.Server.Core/Geek.Server.Core.csproj
dotnet build Geek.Server.Hotfix/Geek.Server.Hotfix.csproj
```

### Running the Server
```bash
# Run the main application
dotnet run --project Geek.Server.App

# Run test client (pressure testing)
dotnet run --project Geek.Server.TestPressure
```

### Code Generation Tools
```bash
# Generate configuration code from Excel files
./Tools/ExcelGen/ExcelToCode.exe
# Click "服务器-ALL" button to export configuration tables

# Generate protocol code from proto definitions
./Tools/Geek.MsgPackTool/MessagePack.Generator.exe
```

### Testing
```bash
# Run all tests
dotnet test

# Run specific test project
dotnet test Geek.Server.TestPressure
```

## Core Architecture

### Actor Model Architecture
- **Actor**: Core execution unit with thread-safe message queue processing
- **Component (Comp)**: Functional modules attached to actors (data containers)
- **Agent**: Hot-reloadable logic handlers that operate on components
- **State**: Persistent data structures automatically serialized to MongoDB

### Key Projects Structure
- **Geek.Server.Core**: Framework core (Actor system, networking, serialization)
- **Geek.Server.App**: Main application entry point and configuration
- **Geek.Server.Hotfix**: Hot-reloadable business logic implementations
- **Geek.Server.Generate**: Auto-generated code from protocols and configs
- **Geek.Server.Proto**: Protocol definitions
- **Geek.Server.CodeGenerator**: Source generators for Actor system

### Actor Types and Threading
- **Server Actor**: Global singleton for server-wide functionality
- **Role Actor**: Per-player instances for player-specific logic
- Each actor runs on its own logical thread with automatic message queuing
- Cross-actor communication is async and thread-safe

### Component Registration Pattern
Components are registered to actors using attributes:
```csharp
[Comp(ActorType.Role)]
public class BagComp : StateComp<BagState> {}

// Agent provides hot-reloadable logic
public class BagCompAgent : StateCompAgent<BagComp, BagState> {}
```

### Hot-Reload System
- Logic code lives in `Geek.Server.Hotfix` project
- Agents can be reloaded without server restart
- State data persists across hot-reloads
- Use `HotfixMgr.LoadHotfixModule()` to trigger reload

### Networking Architecture
- Built on ASP.NET Core Kestrel server
- Supports TCP, HTTP, WebSocket protocols
- MessagePack serialization with polymorphic support
- Handlers implement `BaseMessageHandler` or `BaseHttpHandler`

### Database Integration
- Uses MongoDB for persistent storage
- States implement `IState` interface for auto-persistence
- `GameDB` class handles database operations
- Data is automatically serialized/deserialized

## Development Patterns

### Service Methods
Methods that provide cross-actor services must be marked with `[Service]`:
```csharp
[Service]
public virtual async Task<BagInfo> GetBagInfo(long roleId) {}
```

### Async Patterns
- Use `await` for all async operations
- Mark fire-and-forget methods with `[Discard]`
- Never use `_ = SomeAsyncMethod()` - always use `await`

### Event System
- Use `EventDispatcher` for decoupled communication
- Events are type-safe and async
- Register handlers with `[Event]` attribute

### Timer System
- `GlobalTimer` for scheduling recurring tasks
- `QuartzTimer` for complex scheduling scenarios
- All timers are actor-bound and thread-safe

## Common Development Workflows

### Adding New Functionality
1. Define the Actor type and component structure
2. Create State class for data persistence
3. Create Comp class registered to appropriate Actor
4. Implement Agent class with business logic
5. Add protocol definitions if needed
6. Register handlers for network messages

### Protocol Development
1. Define messages in `Geek.Server.Proto` project
2. Run MessagePack generator to create serialization code
3. Implement handlers in `Geek.Server.Hotfix`
4. Register handlers with `[MsgMapping]` attribute

### Testing Changes
1. Build the solution
2. Run ExcelToCode.exe if config changes were made
3. Run MessagePack.Generator.exe if protocol changes were made
4. Test with GeekServer.TestPressure for load testing
5. Use UnityDemo project for client integration testing

## File Locations
- Configuration: `Geek.Server.App/Configs/`
- Excel templates: `Tools/ExcelGen/Input/`
- Protocol definitions: `Geek.Server.Proto/Proto/`
- Generated code: `Geek.Server.Generate/`
- Hot-reload logic: `Geek.Server.Hotfix/`
- Client demos: `UnityDemo/`, `CocosCreatorDemo/`

## Dependencies
- .NET 7.0 runtime
- MongoDB 4.x or later
- Visual Studio 2022 or compatible IDE
- MessagePack and related serialization libraries