new Vue({
    el: "#app",
    data: {

        a : ["elin", "smelin", "belin", "delin", "kelin"]
    },

    methods: {
        checkR: function () {
           return a.filter(startsWith("e"))
        } 
    }



})