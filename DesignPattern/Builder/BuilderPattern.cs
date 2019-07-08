using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    class BuilderPattern
    {
        /// <summary>
        /// 建造筆電
        /// </summary>
        public class Laptop
        {
            public Processor processor { get; set; }
            public Memory memory { get; set; }
            public Storage storage { get; set; }
            public Graphics graphics { get; set; }
            public Keyboard keyboard { get; set; }

            public string specDetail()
            {
                return $"Processor: {this.processor.name}\n" +
                       $"Memory: {this.memory.size} GB\n" +
                       $"Storage: {this.storage.size} GB\n" +
                       $"Graphics: {this.graphics.name}\n" +
                       $"Keyboard: {this.keyboard.language}";
            }
        }

        #region 規格細項
        public class Processor
        {
            public string name;
            public Processor(string name)
            {
                this.name = name;
            }
        }
        public class Memory
        {
            public int size;
            public Memory(int size)
            {
                this.size = size;
            }
        }
        public class Storage
        {
            public int size;
            public Storage(int size)
            {
                this.size = size;
            }
        }
        public class Graphics
        {
            public string name;
            public Graphics(string name)
            {
                this.name = name;
            }
        }
        public class Keyboard
        {
            public string language;
            public Keyboard(string language)
            {
                this.language = language;
            }
        }
        #endregion

        /// <summary>
        /// 筆電建造者
        /// </summary>
        public abstract class LaptopBuilder
        {
            protected Laptop laptop;

            public LaptopBuilder()
            {
                laptop = new Laptop();
            }

            public abstract LaptopBuilder buildCPU(Processor processor);
            public abstract LaptopBuilder buildMemory(Memory memory);
            public abstract LaptopBuilder buildGraphics(Graphics graphics);
            public abstract LaptopBuilder buildStorage(Storage storage);
            public abstract LaptopBuilder buildKeyboard(Keyboard keyboard);

            public Laptop build() { return laptop; }
        }

        /// <summary>
        /// 實際建造 ASUS 筆電
        /// </summary>
        public class LaptopASUS : LaptopBuilder
        {
            LaptopASUS build()
            {
                return build();
            }
            public LaptopASUS() : base() { }

            public override LaptopBuilder buildCPU(Processor processor)
            {
                this.laptop.processor = processor;
                return this;
            }

            public override LaptopBuilder buildGraphics(Graphics graphics)
            {
                this.laptop.graphics = graphics;
                return this;
            }

            public override LaptopBuilder buildKeyboard(Keyboard keyboard)
            {
                this.laptop.keyboard = keyboard;
                return this;
            }

            public override LaptopBuilder buildMemory(Memory memory)
            {
                this.laptop.memory = memory;
                return this;
            }

            public override LaptopBuilder buildStorage(Storage storage)
            {
                this.laptop.storage = storage;
                return this;
            }
        }

        /// <summary>
        /// 筆電經銷商
        /// </summary>
        public class LaptopSeller
        {
            private LaptopBuilder laptopBuilder;

            public LaptopSeller(LaptopBuilder laptopBuilder)
            {
                this.laptopBuilder = laptopBuilder;
            }

            public Laptop lowSpec()
            {
                laptopBuilder.buildCPU(new Processor("Intel Pentium N5000 四核"));
                laptopBuilder.buildGraphics(new Graphics("Radeon Pro 555X 配備 4GB GDDR5 記憶體"));
                laptopBuilder.buildKeyboard(new Keyboard("TW"));
                laptopBuilder.buildMemory(new Memory(4));
                laptopBuilder.buildStorage(new Storage(128));
                return laptopBuilder.build();
            }
        }

        public class Demo
        {
            public static void main()
            {
                LaptopASUS asus = new LaptopASUS();
                LaptopSeller seller = new LaptopSeller(asus);
                Laptop laptop = seller.lowSpec();

                Console.WriteLine(laptop.specDetail());
            }
        }
    }
}
