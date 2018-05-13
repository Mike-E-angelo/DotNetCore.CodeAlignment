using AutoFixture;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.InProcess;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace DotNetCore.CodeAlignment
{
	public class Program
	{
		static void Main()
		{
			BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly)
			                 .Run();
		}
	}

	sealed class Configuration : ManualConfig
	{
		public Configuration()
		{
			Add(Job.ShortRun.With(InProcessToolchain.Instance));
			Add(MemoryDiagnoser.Default);
		}
	}

	[Config(typeof(Configuration))]
	public class TwoBenchmarks
	{
		[Benchmark(Baseline = true)]
		public int[] First() => NativeArray.Default.Get();

		[Benchmark]
		public int[] Second() => ArrayFromLoop.Default.Get();
	}

	[Config(typeof(Configuration))]
	public class First
	{
		[Benchmark]
		public int[] Run() => NativeArray.Default.Get();
	}

	[Config(typeof(Configuration))]
	public class Second
	{
		[Benchmark]
		public int[] Run() => ArrayFromLoop.Default.Get();
	}

	public interface ISource<out T>
	{
		T Get();
	}

	sealed class NativeArray : ISource<int[]>
	{
		public static NativeArray Default { get; } = new NativeArray();

		NativeArray() : this(Select.Default, Data.Default) {}

		readonly Func<string, int> _select;
		readonly string[]          _data;

		public NativeArray(Func<string, int> select, string[] data)
		{
			_select = select;
			_data   = data;
		}

		public int[] Get() => _data.Select(_select).ToArray();
	}

	sealed class ArrayFromLoop : ISource<int[]>
	{
		public static ArrayFromLoop Default { get; } = new ArrayFromLoop();

		ArrayFromLoop() : this(Select.Default, Data.Default) {}

		readonly Func<string, int> _select;
		readonly string[]          _data;

		public ArrayFromLoop(Func<string, int> select, string[] data)
		{
			_select = select;
			_data   = data;
		}

		public int[] Get()
		{
			var i = 0;
			var r = new int[_data.Length];
			var s = _select;
			foreach (var d in _data)
				r[i++] = s(d);
			return r;
		}
	}

	public class Source<T> : ISource<T>
	{
		public static implicit operator T(Source<T> source) => source.Get();

		readonly T _instance;

		public Source(T instance) => _instance = instance;

		public T Get() => _instance;
	}

	sealed class Data : Source<string[]>
	{
		public static Data Default { get; } = new Data();

		Data() : base(new Fixture().CreateMany<string>(10_000).ToArray()) {}
	}

	sealed class Select : Source<Func<string, int>>
	{
		public static Select Default { get; } = new Select();

		Select() : this(x => default) {}

		public Select(Expression<Func<string, int>> instance) : base(instance.Compile()) {}
	}
}
