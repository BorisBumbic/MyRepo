new Vue({

    data: {
        fieldState: "",
        upAdd: [],
        savedDb: [],
        toggleTable: false,
        addForm: {
            info: null,
            body: null
        }
    },

    async created() {
        let a = await fetch("/api/news/recreate", { method: "POST" })
        this.savedDb = await a.json();
    },

    methods: {
        add: function () {
            this.fieldState = "add" 
            this.savedDb.push(this.addForm)
        }

    }

})