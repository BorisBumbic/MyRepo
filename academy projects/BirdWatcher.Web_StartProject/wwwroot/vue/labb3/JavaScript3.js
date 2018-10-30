new Vue({
    el: "#app",
    data: {

        a: [{ name: "elin" }, { name: "smelin" }, { name: "belin" },
            { name: "delin" }, { name: "kelin" }],
        begins: "",
        bool: false,
        inpy: ""
    },

    computed: {
        filterA: function () {
            return this.a.filter(function (x) {
            return x.name[0] == "e"})
        },

        filterCust: function () {

            let beggy = this.begins;
            let booly = this.bool
            return this.a.filter(function (z) {
                
                if(booly === true)
                    return z.name.startsWith(beggy.toLowerCase());
                if(booly === false)
                return z.name.startsWith(beggy);
            })
        }

        
    },

    methods: {
        add: function () {
            let input = this.inpy;

            this.a.push({name: input});
        }
    }


})