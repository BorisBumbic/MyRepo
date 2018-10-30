new Vue({
    el: "#app",
    data: {
        json: []
    },

    created:  async function fakeDb() {
            let a = await fetch("/products", { method: "GET" });
            console.log(a)
            this.json = await a.json();
        console.log("json", this.json)
    },

    computed: {

        summa: function () {
            console.log("summa")
            let sum = 0;
            for (let x of this.json) {
                sum += x.quantity;
            }
            return sum;
        }
    },

    methods: {

        add: function (x) {
            this.json[x].quantity += 1;
        },

        subtract: function (x) {
            this.json[x].quantity -= 1;
            if (this.json[x].quantity < 0)
                this.json[x].quantity = 0;
        }
    }
})

