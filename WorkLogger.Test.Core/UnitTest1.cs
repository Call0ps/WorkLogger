using System;
using System.Collections.Generic;
using WorkLogger.Core.Entities;
using Xunit;
using Xunit.Abstractions;

namespace WorkLogger.Test;

public class UnitTest1
{
    private readonly ITestOutputHelper _testOutputHelper;

    public UnitTest1(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void TestTimeSpan()
    {
        var timeSpan = new TimeSpan(1, 0, 0);
        var post = new WorkPost
        {
            Start = DateTime.Now,
            End = DateTime.Now + new TimeSpan(1, 0, 0),
            Comment = "Hello!",
            Id = Guid.NewGuid(),
            ProjectId = Guid.NewGuid()
        };
        _testOutputHelper.WriteLine(timeSpan.ToString());
        _testOutputHelper.WriteLine(post.Duration.ToString());
        Assert.Equal(timeSpan.Hours, post.Duration.Hours);
    }

    [Fact]
    public void TestProject()
    {
        var workList = new List<WorkPost>
        {
            new()
            {
                Start = DateTime.Now + new TimeSpan(1, 0, 0, 0),
                End = DateTime.Now + new TimeSpan(1, 0, 0),
                Comment = "Hello!",
                Id = Guid.NewGuid(),
                ProjectId = Guid.NewGuid()
            },
            new()
            {
                Start = DateTime.Now + new TimeSpan(2, 0, 0, 0),
                End = DateTime.Now + new TimeSpan(1, 0, 0),
                Comment = "Hello!",
                Id = Guid.NewGuid(),
                ProjectId = Guid.NewGuid()
            },
            new()
            {
                Start = DateTime.Now,
                End = DateTime.Now + new TimeSpan(1, 0, 0),
                Comment = "Hello!",
                Id = Guid.NewGuid(),
                ProjectId = Guid.NewGuid()
            },
            new()
            {
                Start = DateTime.Now + new TimeSpan(3, 0, 0, 0),
                End = DateTime.Now + new TimeSpan(1, 0, 0),
                Comment = "Hello!",
                Id = Guid.NewGuid(),
                ProjectId = Guid.NewGuid()
            }
        };
        var proj = new Project();
        proj.WorkPosts.AddRange(workList);
        Assert.Equal(proj.WorkPosts, workList);
    }
}