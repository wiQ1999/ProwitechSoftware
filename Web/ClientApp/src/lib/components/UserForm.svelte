<script>
    export let userDto = {
        id: "",
        firstName: "",
        lastName: "",
        email: "",
        phone: "",
    };

    function saveUser() {
        alert("saveUser");
    }
</script>

<form on:submit={saveUser()}>
    <label for={userDto.id}>Id</label>
    <input type="text" bind:value={userDto.id} />
</form>
